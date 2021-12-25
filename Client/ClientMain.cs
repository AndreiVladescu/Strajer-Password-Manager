using SharedLibrary;
using System;
using System.Windows.Forms;

namespace Client
{
    static class ClientMain
    {
        //public static Login loginForm = new Login();
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
