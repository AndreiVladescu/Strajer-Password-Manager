﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ClientMain.client.streamWriter.WriteLine("login");
            ClientMain.client.streamWriter.Flush();
            ClientMain.client.streamWriter.WriteLine(TextBoxUsername.Text);
            ClientMain.client.streamWriter.Flush();
            ClientMain.client.streamWriter.WriteLine(TextBoxPassword.Text);
            ClientMain.client.streamWriter.Flush();
        }
    }
}
