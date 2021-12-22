using System;
using System.Windows.Forms;

namespace Client
{
    public partial class ListForm : Form
    {
        private int listID;

        public ListForm(int newListID)
        {
            listID = newListID;
            InitializeComponent();
        }
        private void InitDesign()
        {
            //dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            if (Int32.Parse(ClientMain.account.RoleID) != 1)
            {
                dataGrid.ReadOnly = true;
                //dataGrid.AllowUserToAddRows = true;
                //dataGrid.AllowUserToDeleteRows = true;
            }
            LblListName.Text = listID.ToString();
        }
        private void ListForm_Load(object sender, EventArgs e)
        {
            LoadCredentials();
            //this.dataGrid.Columns[0].HeaderText = "Password";
            //this.dataGrid.Columns[0].Width = 150;
            //this.dataGrid.Columns[1].HeaderText = "Username";
            //this.dataGrid.Columns[1].Width = 150;
            //this.dataGrid.Columns[2].HeaderText = "Email";
            //this.dataGrid.Columns[2].Width = 150;
            //this.dataGrid.Columns[3].HeaderText = "Title";
            //this.dataGrid.Columns[3].Width = 150;
            //this.dataGrid.Columns[4].HeaderText = "Address";
            //this.dataGrid.Columns[4].Width = 140;
            //this.dataGrid.Columns[5].HeaderText = "Date Added";
            //this.dataGrid.Columns[5].Width = 140;
            //this.dataGrid.Columns[6].HeaderText = "Notes";
            //this.dataGrid.Columns[6].Width = 200;

            InitDesign();

        }

        private void LoadCredentials()
        {
            dataGrid.Columns.Add("Title", "Title");
            dataGrid.Columns.Add("Address", "Address");
            dataGrid.Columns.Add("Passwords", "Passwords");
            dataGrid.Columns.Add("Username", "Username");
            dataGrid.Columns.Add("Date Added", "Date Added");
            dataGrid.Columns.Add("Notes", "Notes");

            var tempListOfLists = ClientMain.credentialsList.GetListOfLists();
            foreach (var tempList in tempListOfLists)
                if (listID == Int32.Parse(tempList[1]))
                    dataGrid.Rows.Add(tempList[6], tempList[5], tempList[3], tempList[4], tempList[2], tempList[7]);

        }
    }
}
