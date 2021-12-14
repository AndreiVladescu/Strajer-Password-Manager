
namespace Client
{
    partial class MainWindow
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SignOffBtn = new System.Windows.Forms.Button();
            this.DesktopPanel = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.SidePanel.Controls.Add(this.CloseBtn);
            this.SidePanel.Controls.Add(this.PrevBtn);
            this.SidePanel.Controls.Add(this.NextBtn);
            this.SidePanel.Controls.Add(this.SignOffBtn);
            this.SidePanel.Location = new System.Drawing.Point(-2, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(151, 501);
            this.SidePanel.TabIndex = 0;
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(3, 463);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(148, 35);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close App";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseApplication);
            // 
            // PrevBtn
            // 
            this.PrevBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBtn.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevBtn.Location = new System.Drawing.Point(3, 71);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(148, 35);
            this.PrevBtn.TabIndex = 3;
            this.PrevBtn.Text = "Prev List";
            this.PrevBtn.UseVisualStyleBackColor = false;
            this.PrevBtn.Click += new System.EventHandler(this.PrevList);
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(3, 30);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(148, 35);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next List";
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextList);
            // 
            // SignOffBtn
            // 
            this.SignOffBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignOffBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignOffBtn.Font = new System.Drawing.Font("Segoe UI Historic", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignOffBtn.Location = new System.Drawing.Point(0, 422);
            this.SignOffBtn.Name = "SignOffBtn";
            this.SignOffBtn.Size = new System.Drawing.Size(148, 35);
            this.SignOffBtn.TabIndex = 1;
            this.SignOffBtn.Text = "Sign Off";
            this.SignOffBtn.UseVisualStyleBackColor = false;
            this.SignOffBtn.Click += new System.EventHandler(this.SignOff);
            // 
            // DesktopPanel
            // 
            this.DesktopPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DesktopPanel.Location = new System.Drawing.Point(155, 0);
            this.DesktopPanel.Name = "DesktopPanel";
            this.DesktopPanel.Size = new System.Drawing.Size(1099, 501);
            this.DesktopPanel.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1266, 513);
            this.Controls.Add(this.DesktopPanel);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainWindow";
            this.Text = "Străjer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button SignOffBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Panel DesktopPanel;
    }
}

