using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;

namespace TurboFinder
{
    class Search
    {
        public List<string> Searching(string Folder, string SearchTerm, string SearchFilter)
        {
            // Initialisze a empty string list
            List<string> files = new List<string>();

            // Take a snapshot of the file system.  
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Folder);

            // This method assumes that the application has discovery permissions for all folders under the specified path 
            IEnumerable<System.IO.FileInfo> fileList;

            // Testing the permissions and gathering the filelist for the selected search folder
            try
            {
                fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            }
            catch (Exception)
            {
                return null; // Abord the search
            }

            // Initialisze a empty string list and gather the different extensions into string tables
            List<string> extentions = new List<string>();

            string[] extensionsIMG = { ".png", ".jpg", ".gif" };
            string[] extensionsVDO = { ".mp4, .avi, .wmv, .mov, .flv" };
            string[] extensionsMSC = { ".aac, .mp3, .ogg, .wav, .flac" };

            // Load the right extension for the specific filter that has to be applied
            switch (SearchFilter)
            {
                case "Extentions":
                    if (SearchTerm.Contains("."))
                    {
                        extentions.Add(SearchTerm);
                    }
                    else
                    {
                        extentions.Add("." + SearchTerm);
                    }
                    break;
                case "Images":
                    extentions.AddRange(extensionsIMG);
                    break;
                case "Videos":
                    extentions.AddRange(extensionsVDO);
                    break;
                case "Music":
                    extentions.AddRange(extensionsMSC);
                    break;
                default:
                    break;
            }

            // For special files use a custom "decoding" methode and for any other files use the basic one located at the end
            // Each SwitchCase consists of a specifically designed filter powered by Linq, files are sorted and selected then added to the "files" StringList

            if (SearchFilter == "Standard")
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Name.Contains(SearchTerm)
                orderby file.Name
                select file;
                files = AddFiles(fileQuery);
            }
            else if (SearchFilter == "Dates")
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.LastWriteTime.Month.ToString() == SearchTerm || file.LastWriteTime.Day.ToString() == SearchTerm || file.LastWriteTime.Year.ToString() == SearchTerm || file.LastWriteTime.Date.ToShortDateString() == SearchTerm
                orderby file.Name
                select file;
                files = AddFiles(fileQuery);
            }
            else if (SearchFilter == "PDF")
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".pdf"
                let fileText = GetFileText(file.FullName) // Custom Text Extractor
                where fileText.Contains(SearchTerm)
                orderby file.Name
                select file;
                files = AddFiles(fileQuery);
            }
            else if (SearchFilter == "DOC")
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".docx" || file.Extension == ".doc"
                let fileText = GetWordText(file.FullName) // Custom Text Extractor
                where fileText.Contains(SearchTerm)
                orderby file.Name
                select file;
                files = AddFiles(fileQuery);
            }
            else if (SearchFilter == "XLS")
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".xlsx" || file.Extension == ".xls"
                let fileText = GetExcelText(file.FullName) // Custom Text Extractor
                where fileText.Contains(SearchTerm)
                orderby file.Name
                select file;
                files = AddFiles(fileQuery);
            }
            else
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where extentions.Any(file.Extension.Contains) && file.Name.Contains(SearchTerm)
                orderby file.Name
                select file;
                files = AddFiles(fileQuery);
            }

            return files; // Collect all the found files and return them
        }

        private List<string> AddFiles(IEnumerable<FileInfo> fileQuery)
        {
            // Initialisze a new empty string
            List<string> files = new List<string>();

            // Execute the query
            foreach (System.IO.FileInfo fi in fileQuery)
            {
                files.Add(fi.FullName);
            }

            // Return result
            return files;
        }
        
        static string GetFileText(string name)
        {
            // Initialisze a new empty string
            string fileContents = String.Empty;

            // Verify if the given file still exists or skip this step
            if (System.IO.File.Exists(name))
            {
                fileContents = System.IO.File.ReadAllText(name); // Read all the content of the given File 
            }
            return fileContents;
        }

        static string GetWordText(string filename)
        {
            // Try to extract all the words inside of a MS Word document
            try
            {
                // Create a new stream process and extract the BodyText of the document inside a string
                Stream stream = File.Open(filename, FileMode.Open);
                WordprocessingDocument wrdprodoc = WordprocessingDocument.Open(stream, true);
                Body body = wrdprodoc.MainDocumentPart.Document.Body;
                string content = body.InnerText;
                return content;
            }
            catch (Exception)
            {
                return ""; // Return an empty string if the File could not be parsed
            }
        }

        static string GetExcelText(string filename)
        {
            // Try to extract all the words inside of a MS Excel document
            try
            {
                // Initialisze a new empty string
                string content = String.Empty;

                // Create a new stream process and extract all the cells content
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (SpreadsheetDocument doc = SpreadsheetDocument.Open(fs, false))
                    {
                        WorkbookPart workbookPart = doc.WorkbookPart;
                        SharedStringTablePart sstpart = workbookPart.GetPartsOfType<SharedStringTablePart>().First();
                        SharedStringTable sst = sstpart.SharedStringTable;

                        WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                        Worksheet sheet = worksheetPart.Worksheet;

                        var cells = sheet.Descendants<Cell>();

                        // Cycle trough all the cells individually and store the extracted content into the content string
                        foreach (Cell cell in cells)
                        {
                            if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))
                            {
                                int ssid = int.Parse(cell.CellValue.Text);
                                string str = sst.ChildElements[ssid].InnerText;
                                content = content + str;
                            }
                            else if (cell.CellValue != null)
                            {
                                content = content + cell.CellValue.Text;
                            }
                        }
                    }
                }
                return content;
            }
            catch (Exception)
            {
                return ""; // Return an empty string if the File could not be parsed
            }
        }
    }
}
