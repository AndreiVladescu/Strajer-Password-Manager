using SharedLibrary;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Client
{
    public partial class Login : Form
    {
        public static MainWindow mainWindow = new MainWindow();
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

                ClientMain.client.streamWriter.WriteLine(Encryption.Caesar(loginPacket.ToString(), 42));
                ClientMain.client.streamWriter.Flush();

                string recvMessageEncoded = Encryption.Caesar(ClientMain.client.streamReader.ReadLine(), -42);
                Packet recvPacket = Packet.ReconstructPacket(recvMessageEncoded);

                if (recvPacket.GetHeader() == PacketHeader.LoginResponsePositive)
                {
                    recvMessageEncoded = Encryption.Caesar(ClientMain.client.streamReader.ReadLine(), -42);
                    Packet detailsPacket = Packet.ReconstructPacket(recvMessageEncoded);
                    recvMessageEncoded = Encryption.Caesar(ClientMain.client.streamReader.ReadLine(), -42);
                    Packet listsPacket = Packet.ReconstructPacket(recvMessageEncoded);

                    SetAccountDetails(detailsPacket);
                    InitLists(listsPacket);

                    //TODO resolve switching forms
                    LblStatus.Text = "Connected";
                    //var frm = mainWindow;
                    var frm = new MainWindow();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();
                }
                else
                    LblStatus.Text = "Could not connect";
            }
            catch (Exception)
            {

            }
        }
        /// <summary>
        /// Method to set account details
        /// </summary>
        /// <param name="detailsPacket"></param>
        private void SetAccountDetails(Packet detailsPacket)
        {
            var decodedMessageList = detailsPacket.GetDecodedMessage();
            ClientMain.account.ID = decodedMessageList[0];
            ClientMain.account.userName = decodedMessageList[1];
            ClientMain.account.RoleID = decodedMessageList[2];
            ClientMain.account.email = decodedMessageList[3];
        }

        private void InitLists(Packet listsPacket)
        {
            var decodedMessageList = listsPacket.GetDecodedMessage();
            // 9 = number of fields per credential slot
            int numberOfLists = decodedMessageList.Count / 9;
            for (int i = 0; i < numberOfLists; i++)
            {
                List<string> credList = new List<string>();
                for (int j = 0; j < 9; j++)
                    credList.Add(decodedMessageList[i * 9 + j]);
                ClientMain.credentialsList.AddCredentialSlot(credList);
            }
            ClientMain.listInfo.numberOfLists = numberOfLists;
        }

        private void CheckBoxPasswordVisibility_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxPassword.PasswordChar = CheckBoxPasswordVisibility.Checked ? '\0' : '*';
        }
    }
}
