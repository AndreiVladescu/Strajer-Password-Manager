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
        bool consoleOutput;
        public Logger(string logExtension = "log", bool writeToConsole = true)
        {
            consoleOutput = writeToConsole;
            string time = DateTime.Now.ToUniversalTime().ToString();
            time = time.Replace('/', '-');
            time = time.Replace(':', '-');
            time = time.Replace(' ', '_');
            fileName = Directory.GetCurrentDirectory() + "\\ServerLogs\\" + time + "." + logExtension;
        }
        public void WriteLine(string message)
        {
            string time = DateTime.Now.ToShortTimeString();
            File.AppendAllText(fileName, time + ": " + message + "\n");
            if (consoleOutput)
                Console.WriteLine(time + ": " + message);
        }
        public void Write(string message)
        {
            string time = DateTime.Now.ToShortTimeString();
            File.AppendAllText(fileName, time + ": " + message);
            if (consoleOutput)
                Console.Write(time + ": " + message);
        }

    }
}
