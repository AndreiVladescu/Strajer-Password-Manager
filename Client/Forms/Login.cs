using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SharedLibrary;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ClientMain.client.Configure(TextBoxServerIP.Text);
                Thread.Sleep(1000);
                ClientMain.client.streamWriter.WriteLine("login");
                ClientMain.client.streamWriter.WriteLine(TextBoxUsername.Text);
                ClientMain.client.streamWriter.WriteLine(TextBoxPassword.Text);
                ClientMain.client.streamWriter.Flush();
            }
            catch(Exception exception)
            {
                LblStatus.Text = "Could not connect to server. Please retry.";
            }
        }
    }
}
