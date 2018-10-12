using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TurboFinder
{
    class Search
    {
        public List<string> Searching(string Folder, string SearchTerm)
        {
            //Initialisze string
            List<string> files = new List<string>();

            // Take a snapshot of the file system.  
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Folder);

            // This method assumes that the application has discovery permissions  
            // for all folders under the specified path.
            IEnumerable<System.IO.FileInfo> fileList = dir.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

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
            IEnumerable<System.IO.FileInfo> fileQuery =
                from file in fileList
                where file.Extension == ".txt"
                orderby file.Name
                select file;


            //Execute the query. This might write out a lot of files!  
            foreach (System.IO.FileInfo fi in fileQuery)
            {
                files.Add(fi.FullName);
            }

            /* Execute the query.  
            foreach (string filename in queryMatchingFiles)
            {
                files.Add(filename);
            }*/

            // Return the array

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
