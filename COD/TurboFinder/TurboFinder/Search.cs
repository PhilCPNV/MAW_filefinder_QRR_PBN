using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (SearchFilter == "Words" || SearchFilter == "Dates")
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Name.Contains(SearchTerm)
                orderby file.Name
                select file;

                // Execute the query
                foreach (System.IO.FileInfo fi in fileQuery)
                {
                    files.Add(fi.FullName);
                }
            }
            else
            {
                IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where extentions.Any(file.Extension.Contains) && file.Name.Contains(SearchTerm)
                orderby file.Name
                select file;

                // Execute the query
                foreach (System.IO.FileInfo fi in fileQuery)
                {
                    files.Add(fi.FullName);
                }
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
            return fileContents;
        }
    }
}
