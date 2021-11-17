using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class ClientMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static NetworkTCPClient client = new NetworkTCPClient();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
