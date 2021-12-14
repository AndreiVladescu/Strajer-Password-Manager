using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class MainWindow : Form
    {
        private Form activeForm;
        private int listID;
        private int numberOfLists;
        List<ListForm> listForms;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignOff(object sender, EventArgs e)
        {
            var frm = new Login();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
         private void OpenChildForm(Form childForm, object btnSender)
        {
            //if (activeForm != null)
            //    activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.DesktopPanel.Controls.Add(childForm);
            this.DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void NextList(object sender, EventArgs e)
        {
            listID++;
            if (listID == numberOfLists)
                listID = 0;
            OpenChildForm(listForms[listID], sender);
        }

        private void PrevList(object sender, EventArgs e)
        {
            listID--;
            if (listID == -1)
                listID = numberOfLists - 1;
            OpenChildForm(listForms[listID], sender);
        }

        private void CloseApplication(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            listID = 0;
            var uniqList = UniqueLists();
            numberOfLists = ClientMain.listInfo.uniqueLists;
            InitLists(uniqList);
            OpenChildForm(listForms[listID], DesktopPanel);
        }

        private List<string> UniqueLists()
        {
            List<string> uniqListID = new List<string>();
            var tempList = ClientMain.credentialsList.GetListOfLists();
            for (int i = 0; i < ClientMain.listInfo.numberOfLists; i++) 
            {
                bool seal = true;
                for (int j = 0; j < uniqListID.Count; j++)
                    if(uniqListID[j] == tempList[i][1])
                    {
                        seal = false;
                        break;
                    }
                if (seal)
                    uniqListID.Add(tempList[i][1]);
            }
            ClientMain.listInfo.uniqueLists = uniqListID.Count;
            return uniqListID;
        }

        private void InitLists(List<string> uniqList)
        {
            listForms = new List<ListForm>();
            for (int i = 0; i < uniqList.Count; i++)
            {
                ListForm tempList = new ListForm(Int32.Parse(uniqList[i]));
                listForms.Add(tempList);
            }
        }
    }
}
