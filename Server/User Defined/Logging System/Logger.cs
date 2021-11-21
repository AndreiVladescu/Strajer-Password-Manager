using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Logger
    {
        string fileName;
        public Logger(string logExtension = "log")
        {
            string time = DateTime.Now.ToUniversalTime().ToString();
            time = time.Replace('/', '-');
            time = time.Replace(':', '-');
            time = time.Replace(' ', '_');
            fileName = Directory.GetCurrentDirectory() + "\\ServerLogs\\" + time + "." + logExtension;
        }
        public void WriteLine(string message)
        {
            string time = DateTime.Now.ToShortTimeString();
            File.AppendAllText(fileName,time + ": " + message + "\n");
        }
        public void Write(string message)
        {
            string time = DateTime.Now.ToShortTimeString();
            File.AppendAllText(fileName, time + ": " + message);
        }

    }
}
