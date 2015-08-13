namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.ipLabel = new System.Windows.Forms.Label();
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.hostName = new System.Windows.Forms.Label();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.installedApplicationsLabel = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Location = new System.Drawing.Point(133, 31);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(72, 13);
            this.ipLabel.TabIndex = 0;
            this.ipLabel.Text = "IP ADDRESS";
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(9, 31);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(118, 13);
            this.ipAddressLabel.TabIndex = 1;
            this.ipAddressLabel.Text = "Your IP Address (Main):";
            // 
            // hostName
            // 
            this.hostName.AutoSize = true;
            this.hostName.Location = new System.Drawing.Point(104, 54);
            this.hostName.Name = "hostName";
            this.hostName.Size = new System.Drawing.Size(71, 13);
            this.hostName.TabIndex = 2;
            this.hostName.Text = "HOST NAME";
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Location = new System.Drawing.Point(9, 54);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(88, 13);
            this.hostNameLabel.TabIndex = 3;
            this.hostNameLabel.Text = "Your Host Name:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(12, 231);
            this.listBox1.Name = "listBox1";
            this.listBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listBox1.Size = new System.Drawing.Size(430, 147);
            this.listBox1.TabIndex = 4;
            // 
            // installedApplicationsLabel
            // 
            this.installedApplicationsLabel.AutoSize = true;
            this.installedApplicationsLabel.Location = new System.Drawing.Point(13, 212);
            this.installedApplicationsLabel.Name = "installedApplicationsLabel";
            this.installedApplicationsLabel.Size = new System.Drawing.Size(109, 13);
            this.installedApplicationsLabel.TabIndex = 5;
            this.installedApplicationsLabel.Text = "Installed Applications:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(318, 212);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(100, 20);
            this.searchBox.TabIndex = 6;
            this.searchBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(262, 212);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 7;
            this.searchLabel.Text = "Search:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 390);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.installedApplicationsLabel);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.hostName);
            this.Controls.Add(this.ipAddressLabel);
            this.Controls.Add(this.ipLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label hostName;
        private System.Windows.Forms.Label hostNameLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label installedApplicationsLabel;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label searchLabel;
    }
}

