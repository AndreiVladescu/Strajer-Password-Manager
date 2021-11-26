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

                Packet loginPacket = new Packet();
                loginPacket.SetHeader(PacketHeader.LoginRequest);
                List<string> loginData = new List<string> { TextBoxUsername.Text, TextBoxPassword.Text };
                loginPacket.SetData(loginData);

                ClientMain.client.streamWriter.WriteLine(loginPacket.ToString());
                ClientMain.client.streamWriter.Flush();

                string recvMessageEncoded = ClientMain.client.streamReader.ReadLine();
                Packet recvPacket = Packet.ReconstructPacket(recvMessageEncoded);
                
                if (recvPacket.GetHeader() == PacketHeader.LoginResponsePositive)
                    LblStatus.Text = "Connected";
                else
                    LblStatus.Text = "Could not connect";
            }
            catch(Exception exception)
            {

            }
        }
    }
}
