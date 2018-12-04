using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TurboFinder
{
    class LogHandler
    {
        public string[] ReadLog(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path, Encoding.UTF8);
            return lines;
        }

        public string[] PublishLog(string path)
        {
            String Date = System.DateTime.Now.ToString("dddd dd MMMM yyyy HH:mm:ss mm");
            string Line = "# Recherche du : " + Date;

            System.IO.File.StreamWriter file = new System.IO.StreamWriter(path, Encoding.UTF8);
            
        }

        // pour split :  string[] logfile = LvLine.Split('%'); 

    }
}
