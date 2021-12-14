using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharedLibrary;

namespace Client
{
    static class ClientMain
    {
        public static NetworkTCPClient client = new NetworkTCPClient();
        public static AccountClass account = new AccountClass();
        public static ListClass credentialsList = new ListClass();
        public static ListInfo listInfo = new ListInfo();
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
