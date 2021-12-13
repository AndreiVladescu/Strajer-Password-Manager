
namespace Client
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckBoxPasswordVisibility = new System.Windows.Forms.CheckBox();
            this.LblStatus = new System.Windows.Forms.Label();
            this.LblServerIP = new System.Windows.Forms.Label();
            this.TextBoxServerIP = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.PictureLogin = new System.Windows.Forms.PictureBox();
            this.LblTitle = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(35)))), ((int)(((byte)(107)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.CheckBoxPasswordVisibility);
            this.panel1.Controls.Add(this.LblStatus);
            this.panel1.Controls.Add(this.LblServerIP);
            this.panel1.Controls.Add(this.TextBoxServerIP);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.PictureLogin);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.TextBoxPassword);
            this.panel1.Controls.Add(this.LblPassword);
            this.panel1.Controls.Add(this.TextBoxUsername);
            this.panel1.Controls.Add(this.LblUsername);
            this.panel1.Location = new System.Drawing.Point(-3, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 559);
            this.panel1.TabIndex = 0;
            // 
            // CheckBoxPasswordVisibility
            // 
            this.CheckBoxPasswordVisibility.AutoSize = true;
            this.CheckBoxPasswordVisibility.Location = new System.Drawing.Point(576, 267);
            this.CheckBoxPasswordVisibility.Name = "CheckBoxPasswordVisibility";
            this.CheckBoxPasswordVisibility.Size = new System.Drawing.Size(18, 17);
            this.CheckBoxPasswordVisibility.TabIndex = 11;
            this.CheckBoxPasswordVisibility.UseVisualStyleBackColor = true;
            this.CheckBoxPasswordVisibility.CheckedChanged += new System.EventHandler(this.CheckBoxPasswordVisibility_CheckedChanged);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblStatus.Location = new System.Drawing.Point(355, 431);
            this.LblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(108, 18);
            this.LblStatus.TabIndex = 10;
            this.LblStatus.Text = "Not Connected";
            // 
            // LblServerIP
            // 
            this.LblServerIP.AutoSize = true;
            this.LblServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServerIP.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblServerIP.Location = new System.Drawing.Point(351, 482);
            this.LblServerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblServerIP.Name = "LblServerIP";
            this.LblServerIP.Size = new System.Drawing.Size(78, 20);
            this.LblServerIP.TabIndex = 9;
            this.LblServerIP.Text = "Server IP";
            // 
            // TextBoxServerIP
            // 
            this.TextBoxServerIP.Location = new System.Drawing.Point(351, 506);
            this.TextBoxServerIP.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxServerIP.Name = "TextBoxServerIP";
            this.TextBoxServerIP.Size = new System.Drawing.Size(172, 22);
            this.TextBoxServerIP.TabIndex = 8;
            this.TextBoxServerIP.Text = "192.168.0.101";
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.SlateGray;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Location = new System.Drawing.Point(353, 327);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(173, 44);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PictureLogin
            // 
            this.PictureLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureLogin.BackgroundImage")));
            this.PictureLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureLogin.Location = new System.Drawing.Point(0, 0);
            this.PictureLogin.Margin = new System.Windows.Forms.Padding(4);
            this.PictureLogin.Name = "PictureLogin";
            this.PictureLogin.Size = new System.Drawing.Size(305, 555);
            this.PictureLogin.TabIndex = 0;
            this.PictureLogin.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblTitle.Location = new System.Drawing.Point(418, 38);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(78, 29);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Login";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(353, 258);
            this.TextBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(172, 22);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblPassword.Location = new System.Drawing.Point(349, 226);
            this.LblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(83, 20);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Password";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(353, 165);
            this.TextBoxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(169, 22);
            this.TextBoxUsername.TabIndex = 2;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LblUsername.Location = new System.Drawing.Point(347, 128);
            this.LblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(86, 20);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 554);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.PictureBox PictureLogin;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblServerIP;
        private System.Windows.Forms.TextBox TextBoxServerIP;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.CheckBox CheckBoxPasswordVisibility;
    }
}