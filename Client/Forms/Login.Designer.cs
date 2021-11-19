
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
            this.LblServerIP = new System.Windows.Forms.Label();
            this.TextBoxServerIP = new System.Windows.Forms.TextBox();
            this.LblStatus = new System.Windows.Forms.Label();
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
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.LblServerIP);
            this.panel1.Controls.Add(this.TextBoxServerIP);
            this.panel1.Controls.Add(this.LblStatus);
            this.panel1.Controls.Add(this.BtnLogin);
            this.panel1.Controls.Add(this.PictureLogin);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.TextBoxPassword);
            this.panel1.Controls.Add(this.LblPassword);
            this.panel1.Controls.Add(this.TextBoxUsername);
            this.panel1.Controls.Add(this.LblUsername);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 454);
            this.panel1.TabIndex = 0;
            // 
            // LblServerIP
            // 
            this.LblServerIP.AutoSize = true;
            this.LblServerIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServerIP.Location = new System.Drawing.Point(263, 392);
            this.LblServerIP.Name = "LblServerIP";
            this.LblServerIP.Size = new System.Drawing.Size(63, 16);
            this.LblServerIP.TabIndex = 9;
            this.LblServerIP.Text = "Server IP";
            // 
            // TextBoxServerIP
            // 
            this.TextBoxServerIP.Location = new System.Drawing.Point(263, 411);
            this.TextBoxServerIP.Name = "TextBoxServerIP";
            this.TextBoxServerIP.Size = new System.Drawing.Size(130, 20);
            this.TextBoxServerIP.TabIndex = 8;
            this.TextBoxServerIP.Text = "192.168.0.101";
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(263, 330);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(97, 16);
            this.LblStatus.TabIndex = 7;
            this.LblStatus.Text = "Not Connected";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(265, 266);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(130, 36);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // PictureLogin
            // 
            this.PictureLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureLogin.BackgroundImage")));
            this.PictureLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureLogin.Location = new System.Drawing.Point(0, 0);
            this.PictureLogin.Name = "PictureLogin";
            this.PictureLogin.Size = new System.Drawing.Size(228, 451);
            this.PictureLogin.TabIndex = 0;
            this.PictureLogin.TabStop = false;
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(303, 20);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(62, 24);
            this.LblTitle.TabIndex = 5;
            this.LblTitle.Text = "Login";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(265, 210);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(130, 20);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(262, 184);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(68, 16);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Password";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(265, 134);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(128, 20);
            this.TextBoxUsername.TabIndex = 2;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.Location = new System.Drawing.Point(260, 104);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(71, 16);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "Username";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 450);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LblServerIP;
        private System.Windows.Forms.TextBox TextBoxServerIP;
    }
}