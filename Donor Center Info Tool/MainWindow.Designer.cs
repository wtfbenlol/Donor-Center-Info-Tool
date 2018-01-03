using System;

namespace Donor_Center_Info_Tool
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateZebraConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zB1GenConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.zB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchButton = new System.Windows.Forms.Button();
            this.centerName = new System.Windows.Forms.TextBox();
            this.searchEntryBox = new System.Windows.Forms.TextBox();
            this.centerSubnet = new System.Windows.Forms.TextBox();
            this.centerNameLabel = new System.Windows.Forms.Label();
            this.centerSubnetLabel = new System.Windows.Forms.Label();
            this.centerPhoneLabel = new System.Windows.Forms.Label();
            this.centerPhone = new System.Windows.Forms.TextBox();
            this.centerTypeLabel = new System.Windows.Forms.Label();
            this.centerType1 = new System.Windows.Forms.TextBox();
            this.centerExtLabel = new System.Windows.Forms.Label();
            this.zebraLabel1 = new System.Windows.Forms.Label();
            this.zebraLabel2 = new System.Windows.Forms.Label();
            this.konicaLabel = new System.Windows.Forms.Label();
            this.centerExtension = new System.Windows.Forms.TextBox();
            this.zebraButton1 = new System.Windows.Forms.Button();
            this.zebraButton2 = new System.Windows.Forms.Button();
            this.konicaButton = new System.Windows.Forms.Button();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchByNameEntry = new System.Windows.Forms.TextBox();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.searchByNameLabel = new System.Windows.Forms.Label();
            this.cneterCodeLabel = new System.Windows.Forms.Label();
            this.centerCodeBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(518, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateZebraConfigFileToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // generateZebraConfigFileToolStripMenuItem
            // 
            this.generateZebraConfigFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zB1GenConfig,
            this.zB2ToolStripMenuItem});
            this.generateZebraConfigFileToolStripMenuItem.Name = "generateZebraConfigFileToolStripMenuItem";
            this.generateZebraConfigFileToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.generateZebraConfigFileToolStripMenuItem.Text = "Generate Zebra Config File";
            // 
            // zB1GenConfig
            // 
            this.zB1GenConfig.Name = "zB1GenConfig";
            this.zB1GenConfig.Size = new System.Drawing.Size(94, 22);
            this.zB1GenConfig.Text = "ZB1";
            this.zB1GenConfig.Click += new System.EventHandler(this.zB1GenConfig_Click);
            // 
            // zB2ToolStripMenuItem
            // 
            this.zB2ToolStripMenuItem.Name = "zB2ToolStripMenuItem";
            this.zB2ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.zB2ToolStripMenuItem.Text = "ZB2";
            this.zB2ToolStripMenuItem.Click += new System.EventHandler(this.zB2ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.reportAnIssueToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reportAnIssueToolStripMenuItem
            // 
            this.reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
            this.reportAnIssueToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.reportAnIssueToolStripMenuItem.Text = "Report an Issue";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(221, 211);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 20);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search By Code";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // centerName
            // 
            this.centerName.Location = new System.Drawing.Point(123, 44);
            this.centerName.Name = "centerName";
            this.centerName.ReadOnly = true;
            this.centerName.Size = new System.Drawing.Size(100, 20);
            this.centerName.TabIndex = 4;
            this.centerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchEntryBox
            // 
            this.searchEntryBox.AcceptsReturn = true;
            this.searchEntryBox.Location = new System.Drawing.Point(112, 211);
            this.searchEntryBox.Name = "searchEntryBox";
            this.searchEntryBox.Size = new System.Drawing.Size(100, 20);
            this.searchEntryBox.TabIndex = 5;
            // 
            // centerSubnet
            // 
            this.centerSubnet.Location = new System.Drawing.Point(123, 70);
            this.centerSubnet.Name = "centerSubnet";
            this.centerSubnet.ReadOnly = true;
            this.centerSubnet.Size = new System.Drawing.Size(100, 20);
            this.centerSubnet.TabIndex = 6;
            this.centerSubnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // centerNameLabel
            // 
            this.centerNameLabel.AutoSize = true;
            this.centerNameLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.centerNameLabel.Location = new System.Drawing.Point(24, 47);
            this.centerNameLabel.Name = "centerNameLabel";
            this.centerNameLabel.Size = new System.Drawing.Size(69, 13);
            this.centerNameLabel.TabIndex = 7;
            this.centerNameLabel.Text = "Center Name\r\n";
            // 
            // centerSubnetLabel
            // 
            this.centerSubnetLabel.AutoSize = true;
            this.centerSubnetLabel.Location = new System.Drawing.Point(24, 73);
            this.centerSubnetLabel.Name = "centerSubnetLabel";
            this.centerSubnetLabel.Size = new System.Drawing.Size(75, 13);
            this.centerSubnetLabel.TabIndex = 8;
            this.centerSubnetLabel.Text = "Center Subnet";
            // 
            // centerPhoneLabel
            // 
            this.centerPhoneLabel.AutoSize = true;
            this.centerPhoneLabel.Location = new System.Drawing.Point(24, 100);
            this.centerPhoneLabel.Name = "centerPhoneLabel";
            this.centerPhoneLabel.Size = new System.Drawing.Size(72, 13);
            this.centerPhoneLabel.TabIndex = 9;
            this.centerPhoneLabel.Text = "Center Phone";
            // 
            // centerPhone
            // 
            this.centerPhone.Location = new System.Drawing.Point(123, 97);
            this.centerPhone.Name = "centerPhone";
            this.centerPhone.ReadOnly = true;
            this.centerPhone.Size = new System.Drawing.Size(100, 20);
            this.centerPhone.TabIndex = 10;
            this.centerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // centerTypeLabel
            // 
            this.centerTypeLabel.AutoSize = true;
            this.centerTypeLabel.Location = new System.Drawing.Point(24, 127);
            this.centerTypeLabel.Name = "centerTypeLabel";
            this.centerTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.centerTypeLabel.TabIndex = 11;
            this.centerTypeLabel.Text = "Center Type";
            // 
            // centerType1
            // 
            this.centerType1.Location = new System.Drawing.Point(123, 124);
            this.centerType1.Name = "centerType1";
            this.centerType1.ReadOnly = true;
            this.centerType1.Size = new System.Drawing.Size(100, 20);
            this.centerType1.TabIndex = 12;
            this.centerType1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // centerExtLabel
            // 
            this.centerExtLabel.AutoSize = true;
            this.centerExtLabel.Location = new System.Drawing.Point(285, 44);
            this.centerExtLabel.Name = "centerExtLabel";
            this.centerExtLabel.Size = new System.Drawing.Size(87, 13);
            this.centerExtLabel.TabIndex = 13;
            this.centerExtLabel.Text = "Center Extension";
            // 
            // zebraLabel1
            // 
            this.zebraLabel1.AutoSize = true;
            this.zebraLabel1.Location = new System.Drawing.Point(285, 73);
            this.zebraLabel1.Name = "zebraLabel1";
            this.zebraLabel1.Size = new System.Drawing.Size(44, 13);
            this.zebraLabel1.TabIndex = 14;
            this.zebraLabel1.Text = "Zebra 1";
            // 
            // zebraLabel2
            // 
            this.zebraLabel2.AutoSize = true;
            this.zebraLabel2.Location = new System.Drawing.Point(285, 100);
            this.zebraLabel2.Name = "zebraLabel2";
            this.zebraLabel2.Size = new System.Drawing.Size(44, 13);
            this.zebraLabel2.TabIndex = 15;
            this.zebraLabel2.Text = "Zebra 2";
            // 
            // konicaLabel
            // 
            this.konicaLabel.AutoSize = true;
            this.konicaLabel.Location = new System.Drawing.Point(285, 127);
            this.konicaLabel.Name = "konicaLabel";
            this.konicaLabel.Size = new System.Drawing.Size(40, 13);
            this.konicaLabel.TabIndex = 16;
            this.konicaLabel.Text = "Konica";
            // 
            // centerExtension
            // 
            this.centerExtension.Location = new System.Drawing.Point(403, 44);
            this.centerExtension.Name = "centerExtension";
            this.centerExtension.ReadOnly = true;
            this.centerExtension.Size = new System.Drawing.Size(100, 20);
            this.centerExtension.TabIndex = 17;
            this.centerExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zebraButton1
            // 
            this.zebraButton1.Location = new System.Drawing.Point(403, 68);
            this.zebraButton1.Name = "zebraButton1";
            this.zebraButton1.Size = new System.Drawing.Size(100, 23);
            this.zebraButton1.TabIndex = 18;
            this.zebraButton1.Tag = "Zebra1";
            this.zebraButton1.UseVisualStyleBackColor = true;
            this.zebraButton1.Click += new System.EventHandler(this.zebraButton1_Click);
            // 
            // zebraButton2
            // 
            this.zebraButton2.Location = new System.Drawing.Point(403, 95);
            this.zebraButton2.Name = "zebraButton2";
            this.zebraButton2.Size = new System.Drawing.Size(100, 23);
            this.zebraButton2.TabIndex = 19;
            this.zebraButton2.Tag = "Zebra2";
            this.zebraButton2.UseVisualStyleBackColor = true;
            this.zebraButton2.Click += new System.EventHandler(this.zebraButton2_Click);
            // 
            // konicaButton
            // 
            this.konicaButton.Location = new System.Drawing.Point(403, 121);
            this.konicaButton.Name = "konicaButton";
            this.konicaButton.Size = new System.Drawing.Size(100, 23);
            this.konicaButton.TabIndex = 20;
            this.konicaButton.UseVisualStyleBackColor = true;
            this.konicaButton.Click += new System.EventHandler(this.konicaButton_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(12, 215);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(94, 13);
            this.searchLabel.TabIndex = 21;
            this.searchLabel.Text = "Enter Center Code";
            // 
            // searchByNameEntry
            // 
            this.searchByNameEntry.AcceptsReturn = true;
            this.searchByNameEntry.Location = new System.Drawing.Point(112, 254);
            this.searchByNameEntry.Name = "searchByNameEntry";
            this.searchByNameEntry.Size = new System.Drawing.Size(100, 20);
            this.searchByNameEntry.TabIndex = 22;
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Location = new System.Drawing.Point(221, 252);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(104, 23);
            this.searchByNameButton.TabIndex = 23;
            this.searchByNameButton.Text = "Search By Name";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            this.searchByNameButton.Click += new System.EventHandler(this.searchByNameButton_Click);
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.AutoSize = true;
            this.searchByNameLabel.Location = new System.Drawing.Point(12, 257);
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(87, 13);
            this.searchByNameLabel.TabIndex = 24;
            this.searchByNameLabel.Text = "Search By Name";
            // 
            // cneterCodeLabel
            // 
            this.cneterCodeLabel.AutoSize = true;
            this.cneterCodeLabel.Location = new System.Drawing.Point(24, 156);
            this.cneterCodeLabel.Name = "cneterCodeLabel";
            this.cneterCodeLabel.Size = new System.Drawing.Size(66, 13);
            this.cneterCodeLabel.TabIndex = 25;
            this.cneterCodeLabel.Text = "Center Code";
            // 
            // centerCodeBox
            // 
            this.centerCodeBox.Location = new System.Drawing.Point(123, 153);
            this.centerCodeBox.Name = "centerCodeBox";
            this.centerCodeBox.ReadOnly = true;
            this.centerCodeBox.Size = new System.Drawing.Size(100, 20);
            this.centerCodeBox.TabIndex = 26;
            this.centerCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 298);
            this.Controls.Add(this.centerCodeBox);
            this.Controls.Add(this.cneterCodeLabel);
            this.Controls.Add(this.searchByNameLabel);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.searchByNameEntry);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.konicaButton);
            this.Controls.Add(this.zebraButton2);
            this.Controls.Add(this.zebraButton1);
            this.Controls.Add(this.centerExtension);
            this.Controls.Add(this.konicaLabel);
            this.Controls.Add(this.zebraLabel2);
            this.Controls.Add(this.zebraLabel1);
            this.Controls.Add(this.centerExtLabel);
            this.Controls.Add(this.centerType1);
            this.Controls.Add(this.centerTypeLabel);
            this.Controls.Add(this.centerPhone);
            this.Controls.Add(this.centerPhoneLabel);
            this.Controls.Add(this.centerSubnetLabel);
            this.Controls.Add(this.centerNameLabel);
            this.Controls.Add(this.centerSubnet);
            this.Controls.Add(this.searchEntryBox);
            this.Controls.Add(this.centerName);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Donor Center Info Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox centerName;
        private System.Windows.Forms.TextBox searchEntryBox;
        private System.Windows.Forms.TextBox centerSubnet;
        private System.Windows.Forms.Label centerNameLabel;
        private System.Windows.Forms.Label centerSubnetLabel;
        private System.Windows.Forms.Label centerPhoneLabel;
        private System.Windows.Forms.TextBox centerPhone;
        private System.Windows.Forms.Label centerTypeLabel;
        private System.Windows.Forms.TextBox centerType1;
        private System.Windows.Forms.Label centerExtLabel;
        private System.Windows.Forms.Label zebraLabel1;
        private System.Windows.Forms.Label zebraLabel2;
        private System.Windows.Forms.Label konicaLabel;
        private System.Windows.Forms.TextBox centerExtension;
        private System.Windows.Forms.Button zebraButton1;
        private System.Windows.Forms.Button zebraButton2;
        private System.Windows.Forms.Button konicaButton;
        private System.Windows.Forms.ToolStripMenuItem generateZebraConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zB1GenConfig;
        private System.Windows.Forms.ToolStripMenuItem zB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAnIssueToolStripMenuItem;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchByNameEntry;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.Label searchByNameLabel;
        private System.Windows.Forms.Label cneterCodeLabel;
        private System.Windows.Forms.TextBox centerCodeBox;
    }
}

