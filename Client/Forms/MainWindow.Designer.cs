
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSignOff = new System.Windows.Forms.Button();
            this.DataGridPasswords = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPasswords)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.panel1.Controls.Add(this.BtnSignOff);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 543);
            this.panel1.TabIndex = 0;
            // 
            // BtnSignOff
            // 
            this.BtnSignOff.BackColor = System.Drawing.Color.Teal;
            this.BtnSignOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSignOff.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignOff.Location = new System.Drawing.Point(4, 490);
            this.BtnSignOff.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSignOff.Name = "BtnSignOff";
            this.BtnSignOff.Size = new System.Drawing.Size(197, 43);
            this.BtnSignOff.TabIndex = 1;
            this.BtnSignOff.Text = "Sign Off";
            this.BtnSignOff.UseVisualStyleBackColor = false;
            this.BtnSignOff.Click += new System.EventHandler(this.BtnSignOff_Click);
            // 
            // DataGridPasswords
            // 
            this.DataGridPasswords.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(95)))), ((int)(((byte)(137)))));
            this.DataGridPasswords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridPasswords.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridPasswords.Location = new System.Drawing.Point(211, 15);
            this.DataGridPasswords.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridPasswords.Name = "DataGridPasswords";
            this.DataGridPasswords.RowHeadersWidth = 51;
            this.DataGridPasswords.Size = new System.Drawing.Size(840, 511);
            this.DataGridPasswords.TabIndex = 1;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(79)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(1067, 540);
            this.Controls.Add(this.DataGridPasswords);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Străjer";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPasswords)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSignOff;
        private System.Windows.Forms.DataGridView DataGridPasswords;
    }
}

