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
            numberOfLists = ClientMain.listInfo.numberOfLists;
            InitLists();
            OpenChildForm(listForms[listID], DesktopPanel);
        }
        private void InitLists()
        {
            listForms = new List<ListForm>();
            for (int i = 0; i < numberOfLists; i++)
            {
                ListForm tempList = new ListForm(i);
                listForms.Add(tempList);
            }
        }
    }
}
