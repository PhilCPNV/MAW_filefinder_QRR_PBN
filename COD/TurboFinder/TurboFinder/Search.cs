using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Spreadsheet;

namespace TurboFinder
{
    class Search
    {
        public List<string> Searching(string Folder, string SearchTerm, string SearchFilter)
        {
            //Initialisze string
            List<string> files = new List<string>();

            // Take a snapshot of the file system.  
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Folder);

            // This method assumes that the application has discovery permissions  
            // for all folders under the specified path.

            IEnumerable<System.IO.FileInfo> fileList;

            try
            {
                fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);
            }
            catch (Exception)
            {
                MessageBox.Show("Vous ne possèdez pas les droits néssésaire pour certains fichier ou dossier.");
                return null;
            }

            // Search the contents of each file.  
            // A regular expression created with the RegEx class  
            // could be used instead of the Contains method.  
            /* queryMatchingFiles is an IEnumerable<string>.  
            var queryMatchingFiles =
                from file in fileList
                where file.Extension == ".*"
                let fileText = GetFileText(file.FullName)
                where fileText.Contains(SearchTerm)
                select file.FullName;
            */

            //Create the query  

            List<string> extentions = new List<string>();

            string[] extensionsIMG = { ".png", ".jpg", ".gif" };
            string[] extensionsVDO = { ".mp4, .avi, .wmv, .mov, .flv" };
            string[] extensionsMSC = { ".aac, .mp3, .ogg, .wav, .flac" };

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
                where file.LastWriteTime.Month.ToString() == SearchTerm || file.LastWriteTime.Day.ToString() == SearchTerm || file.LastWriteTime.Year.ToString() == SearchTerm
                orderby file.Name
                select file;
                files = AddFiles(fileQuery);
            }
            else if (SearchFilter == "PDF")
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".pdf"
                let fileText = GetFileText(file.FullName)
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
                let fileText = GetWordText(file.FullName)
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
                let fileText = GetExcelText(file.FullName)
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

            return files;
        }

        private List<string> AddFiles(IEnumerable<FileInfo> fileQuery)
        {
            //Initialisze string
            List<string> files = new List<string>();

            // Execute the query
            foreach (System.IO.FileInfo fi in fileQuery)
            {
                files.Add(fi.FullName);
            }

            return files;
        }

        // Read the contents of the file.  
        static string GetFileText(string name)
        {
            string fileContents = String.Empty;

            // If the file has been deleted since we took   
            // the snapshot, ignore it and return the empty string.  
            if (System.IO.File.Exists(name))
            {
                fileContents = System.IO.File.ReadAllText(name);
            }
            MessageBox.Show(fileContents);
            return fileContents;
        }

        static string GetWordText(string filename)
        {
            try
            {
                Stream stream = File.Open(filename, FileMode.Open);
                WordprocessingDocument wrdprodoc = WordprocessingDocument.Open(stream, true);
                Body body = wrdprodoc.MainDocumentPart.Document.Body;
                string content = body.InnerText;
                return content;
            }
            catch (Exception)
            {
                return "";
            }
        }

        static string GetExcelText(string filename)
        {
            string content = "";

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
                    var rows = sheet.Descendants<Row>();

                    Console.WriteLine("Row count = {0}", rows.LongCount());
                    Console.WriteLine("Cell count = {0}", cells.LongCount());

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
            MessageBox.Show(content);
            return content;
        }
    }
}
