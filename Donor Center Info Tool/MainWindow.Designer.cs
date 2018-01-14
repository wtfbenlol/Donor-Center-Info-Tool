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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateZebraConfigFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zB1GenConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.zB2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generatePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportAnIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchEntryBox = new System.Windows.Forms.TextBox();
            this.centerNameLabel = new System.Windows.Forms.Label();
            this.centerSubnetLabel = new System.Windows.Forms.Label();
            this.centerPhoneLabel = new System.Windows.Forms.Label();
            this.centerTypeLabel = new System.Windows.Forms.Label();
            this.centerExtLabel = new System.Windows.Forms.Label();
            this.zebraLabel1 = new System.Windows.Forms.Label();
            this.zebraLabel2 = new System.Windows.Forms.Label();
            this.konicaLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchByNameEntry = new System.Windows.Forms.TextBox();
            this.searchByNameLabel = new System.Windows.Forms.Label();
            this.cneterCodeLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripPwGen = new System.Windows.Forms.ToolStripButton();
            this.toolStripClearFields = new System.Windows.Forms.ToolStripButton();
            this.toolStripExitButton = new System.Windows.Forms.ToolStripButton();
            this.generatePasswordListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.savePwFile = new System.Windows.Forms.SaveFileDialog();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.centerCodeBox = new Donor_Center_Info_Tool.DonorTextBox();
            this.searchByNameButton = new Donor_Center_Info_Tool.DonorButton();
            this.konicaButton = new Donor_Center_Info_Tool.DonorButton();
            this.zebraButton2 = new Donor_Center_Info_Tool.DonorButton();
            this.zebraButton1 = new Donor_Center_Info_Tool.DonorButton();
            this.centerExtension = new Donor_Center_Info_Tool.DonorTextBox();
            this.centerType1 = new Donor_Center_Info_Tool.DonorTextBox();
            this.centerPhone = new Donor_Center_Info_Tool.DonorTextBox();
            this.centerSubnet = new Donor_Center_Info_Tool.DonorTextBox();
            this.centerName = new Donor_Center_Info_Tool.DonorTextBox();
            this.searchButton = new Donor_Center_Info_Tool.DonorButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(519, 24);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearWindowToolStripMenuItem,
            this.preferencesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // clearWindowToolStripMenuItem
            // 
            this.clearWindowToolStripMenuItem.Name = "clearWindowToolStripMenuItem";
            this.clearWindowToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.clearWindowToolStripMenuItem.Text = "Clear Window";
            this.clearWindowToolStripMenuItem.Click += new System.EventHandler(this.ClearWindowToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateZebraConfigFileToolStripMenuItem,
            this.generatePasswordToolStripMenuItem,
            this.generatePasswordListToolStripMenuItem});
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
            this.zB1GenConfig.Click += new System.EventHandler(this.ZB1GenConfig_Click);
            // 
            // zB2ToolStripMenuItem
            // 
            this.zB2ToolStripMenuItem.Name = "zB2ToolStripMenuItem";
            this.zB2ToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.zB2ToolStripMenuItem.Text = "ZB2";
            this.zB2ToolStripMenuItem.Click += new System.EventHandler(this.ZB2ToolStripMenuItem_Click);
            // 
            // generatePasswordToolStripMenuItem
            // 
            this.generatePasswordToolStripMenuItem.Name = "generatePasswordToolStripMenuItem";
            this.generatePasswordToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.generatePasswordToolStripMenuItem.Text = "Generate Password";
            this.generatePasswordToolStripMenuItem.Click += new System.EventHandler(this.generatePasswordToolStripMenuItem_Click);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // reportAnIssueToolStripMenuItem
            // 
            this.reportAnIssueToolStripMenuItem.Name = "reportAnIssueToolStripMenuItem";
            this.reportAnIssueToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.reportAnIssueToolStripMenuItem.Text = "Report an Issue";
            // 
            // searchEntryBox
            // 
            this.searchEntryBox.AcceptsReturn = true;
            this.searchEntryBox.Location = new System.Drawing.Point(101, 278);
            this.searchEntryBox.Name = "searchEntryBox";
            this.searchEntryBox.Size = new System.Drawing.Size(117, 20);
            this.searchEntryBox.TabIndex = 5;
            // 
            // centerNameLabel
            // 
            this.centerNameLabel.AutoSize = true;
            this.centerNameLabel.BackColor = System.Drawing.SystemColors.Control;
            this.centerNameLabel.Location = new System.Drawing.Point(13, 92);
            this.centerNameLabel.Name = "centerNameLabel";
            this.centerNameLabel.Size = new System.Drawing.Size(69, 13);
            this.centerNameLabel.TabIndex = 7;
            this.centerNameLabel.Text = "Center Name\r\n";
            // 
            // centerSubnetLabel
            // 
            this.centerSubnetLabel.AutoSize = true;
            this.centerSubnetLabel.Location = new System.Drawing.Point(12, 118);
            this.centerSubnetLabel.Name = "centerSubnetLabel";
            this.centerSubnetLabel.Size = new System.Drawing.Size(75, 13);
            this.centerSubnetLabel.TabIndex = 8;
            this.centerSubnetLabel.Text = "Center Subnet";
            // 
            // centerPhoneLabel
            // 
            this.centerPhoneLabel.AutoSize = true;
            this.centerPhoneLabel.Location = new System.Drawing.Point(13, 144);
            this.centerPhoneLabel.Name = "centerPhoneLabel";
            this.centerPhoneLabel.Size = new System.Drawing.Size(72, 13);
            this.centerPhoneLabel.TabIndex = 9;
            this.centerPhoneLabel.Text = "Center Phone";
            // 
            // centerTypeLabel
            // 
            this.centerTypeLabel.AutoSize = true;
            this.centerTypeLabel.Location = new System.Drawing.Point(13, 172);
            this.centerTypeLabel.Name = "centerTypeLabel";
            this.centerTypeLabel.Size = new System.Drawing.Size(65, 13);
            this.centerTypeLabel.TabIndex = 11;
            this.centerTypeLabel.Text = "Center Type";
            // 
            // centerExtLabel
            // 
            this.centerExtLabel.AutoSize = true;
            this.centerExtLabel.Location = new System.Drawing.Point(12, 226);
            this.centerExtLabel.Name = "centerExtLabel";
            this.centerExtLabel.Size = new System.Drawing.Size(87, 13);
            this.centerExtLabel.TabIndex = 13;
            this.centerExtLabel.Text = "Center Extension";
            // 
            // zebraLabel1
            // 
            this.zebraLabel1.AutoSize = true;
            this.zebraLabel1.Location = new System.Drawing.Point(244, 168);
            this.zebraLabel1.Name = "zebraLabel1";
            this.zebraLabel1.Size = new System.Drawing.Size(44, 13);
            this.zebraLabel1.TabIndex = 14;
            this.zebraLabel1.Text = "Zebra 1";
            // 
            // zebraLabel2
            // 
            this.zebraLabel2.AutoSize = true;
            this.zebraLabel2.Location = new System.Drawing.Point(244, 197);
            this.zebraLabel2.Name = "zebraLabel2";
            this.zebraLabel2.Size = new System.Drawing.Size(44, 13);
            this.zebraLabel2.TabIndex = 15;
            this.zebraLabel2.Text = "Zebra 2";
            // 
            // konicaLabel
            // 
            this.konicaLabel.AutoSize = true;
            this.konicaLabel.Location = new System.Drawing.Point(244, 225);
            this.konicaLabel.Name = "konicaLabel";
            this.konicaLabel.Size = new System.Drawing.Size(40, 13);
            this.konicaLabel.TabIndex = 16;
            this.konicaLabel.Text = "Konica";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(5, 281);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(94, 13);
            this.searchLabel.TabIndex = 21;
            this.searchLabel.Text = "Enter Center Code";
            // 
            // searchByNameEntry
            // 
            this.searchByNameEntry.AcceptsReturn = true;
            this.searchByNameEntry.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.searchByNameEntry.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.searchByNameEntry.Location = new System.Drawing.Point(101, 309);
            this.searchByNameEntry.Name = "searchByNameEntry";
            this.searchByNameEntry.Size = new System.Drawing.Size(117, 20);
            this.searchByNameEntry.TabIndex = 22;
            // 
            // searchByNameLabel
            // 
            this.searchByNameLabel.AutoSize = true;
            this.searchByNameLabel.Location = new System.Drawing.Point(12, 312);
            this.searchByNameLabel.Name = "searchByNameLabel";
            this.searchByNameLabel.Size = new System.Drawing.Size(87, 13);
            this.searchByNameLabel.TabIndex = 24;
            this.searchByNameLabel.Text = "Search By Name";
            // 
            // cneterCodeLabel
            // 
            this.cneterCodeLabel.AutoSize = true;
            this.cneterCodeLabel.Location = new System.Drawing.Point(12, 200);
            this.cneterCodeLabel.Name = "cneterCodeLabel";
            this.cneterCodeLabel.Size = new System.Drawing.Size(66, 13);
            this.cneterCodeLabel.TabIndex = 25;
            this.cneterCodeLabel.Text = "Center Code";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPwGen,
            this.toolStripClearFields,
            this.toolStripSeparator1,
            this.toolStripExitButton,
            this.toolStripSeparator2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(519, 25);
            this.toolStrip1.TabIndex = 27;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripPwGen
            // 
            this.toolStripPwGen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripPwGen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPwGen.Image")));
            this.toolStripPwGen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPwGen.Name = "toolStripPwGen";
            this.toolStripPwGen.Size = new System.Drawing.Size(23, 22);
            this.toolStripPwGen.Text = "toolStripButton1";
            this.toolStripPwGen.ToolTipText = "Generates a new SOX compliant password";
            this.toolStripPwGen.Click += new System.EventHandler(this.toolStripPwGen_Click);
            // 
            // toolStripClearFields
            // 
            this.toolStripClearFields.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripClearFields.Image = ((System.Drawing.Image)(resources.GetObject("toolStripClearFields.Image")));
            this.toolStripClearFields.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClearFields.Name = "toolStripClearFields";
            this.toolStripClearFields.Size = new System.Drawing.Size(23, 22);
            this.toolStripClearFields.Text = "toolStripButton1";
            this.toolStripClearFields.ToolTipText = "Clear fields";
            this.toolStripClearFields.Click += new System.EventHandler(this.toolStripClearFields_Click);
            // 
            // toolStripExitButton
            // 
            this.toolStripExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripExitButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExitButton.Image")));
            this.toolStripExitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripExitButton.Name = "toolStripExitButton";
            this.toolStripExitButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripExitButton.Text = "toolStripButton1";
            this.toolStripExitButton.ToolTipText = "Exit Application";
            this.toolStripExitButton.Click += new System.EventHandler(this.toolStripExitButton_Click);
            // 
            // generatePasswordListToolStripMenuItem
            // 
            this.generatePasswordListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.generatePasswordListToolStripMenuItem.Name = "generatePasswordListToolStripMenuItem";
            this.generatePasswordListToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.generatePasswordListToolStripMenuItem.Text = "Generate Password List";
            this.generatePasswordListToolStripMenuItem.ToolTipText = "Generates a list of 100 passwords and saves them in the selected location";
            this.generatePasswordListToolStripMenuItem.Click += new System.EventHandler(this.generatePasswordListToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem2.Text = "25";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem3.Text = "50";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(92, 22);
            this.toolStripMenuItem4.Text = "100";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // savePwFile
            // 
            this.savePwFile.Title = "Save Password File";
            this.savePwFile.FileOk += new System.ComponentModel.CancelEventHandler(this.savePwFile_FileOk);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Application Information";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // centerCodeBox
            // 
            this.centerCodeBox.CanBeCleared = true;
            this.centerCodeBox.Location = new System.Drawing.Point(101, 197);
            this.centerCodeBox.Name = "centerCodeBox";
            this.centerCodeBox.ReadOnly = true;
            this.centerCodeBox.Size = new System.Drawing.Size(116, 20);
            this.centerCodeBox.TabIndex = 26;
            this.centerCodeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.CanBeCleared = false;
            this.searchByNameButton.Location = new System.Drawing.Point(224, 307);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(104, 23);
            this.searchByNameButton.TabIndex = 23;
            this.searchByNameButton.Text = "Search By Name";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            this.searchByNameButton.Click += new System.EventHandler(this.SearchByNameButton_Click);
            // 
            // konicaButton
            // 
            this.konicaButton.CanBeCleared = true;
            this.konicaButton.Location = new System.Drawing.Point(294, 220);
            this.konicaButton.Name = "konicaButton";
            this.konicaButton.Size = new System.Drawing.Size(100, 23);
            this.konicaButton.TabIndex = 20;
            this.konicaButton.UseVisualStyleBackColor = true;
            this.konicaButton.Click += new System.EventHandler(this.KonicaButton_Click);
            // 
            // zebraButton2
            // 
            this.zebraButton2.CanBeCleared = true;
            this.zebraButton2.Location = new System.Drawing.Point(294, 192);
            this.zebraButton2.Name = "zebraButton2";
            this.zebraButton2.Size = new System.Drawing.Size(100, 23);
            this.zebraButton2.TabIndex = 19;
            this.zebraButton2.Tag = "Zebra2";
            this.zebraButton2.UseVisualStyleBackColor = true;
            this.zebraButton2.Click += new System.EventHandler(this.ZebraButton2_Click);
            // 
            // zebraButton1
            // 
            this.zebraButton1.CanBeCleared = true;
            this.zebraButton1.Location = new System.Drawing.Point(294, 163);
            this.zebraButton1.Name = "zebraButton1";
            this.zebraButton1.Size = new System.Drawing.Size(100, 23);
            this.zebraButton1.TabIndex = 18;
            this.zebraButton1.Tag = "Zebra1";
            this.zebraButton1.UseVisualStyleBackColor = true;
            this.zebraButton1.Click += new System.EventHandler(this.ZebraButton1_Click);
            // 
            // centerExtension
            // 
            this.centerExtension.CanBeCleared = true;
            this.centerExtension.Location = new System.Drawing.Point(101, 223);
            this.centerExtension.Name = "centerExtension";
            this.centerExtension.ReadOnly = true;
            this.centerExtension.Size = new System.Drawing.Size(116, 20);
            this.centerExtension.TabIndex = 17;
            this.centerExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // centerType1
            // 
            this.centerType1.CanBeCleared = true;
            this.centerType1.Location = new System.Drawing.Point(101, 169);
            this.centerType1.Name = "centerType1";
            this.centerType1.ReadOnly = true;
            this.centerType1.Size = new System.Drawing.Size(116, 20);
            this.centerType1.TabIndex = 12;
            this.centerType1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // centerPhone
            // 
            this.centerPhone.CanBeCleared = true;
            this.centerPhone.Location = new System.Drawing.Point(102, 141);
            this.centerPhone.Name = "centerPhone";
            this.centerPhone.ReadOnly = true;
            this.centerPhone.Size = new System.Drawing.Size(116, 20);
            this.centerPhone.TabIndex = 10;
            this.centerPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // centerSubnet
            // 
            this.centerSubnet.CanBeCleared = true;
            this.centerSubnet.Location = new System.Drawing.Point(101, 115);
            this.centerSubnet.Name = "centerSubnet";
            this.centerSubnet.ReadOnly = true;
            this.centerSubnet.Size = new System.Drawing.Size(116, 20);
            this.centerSubnet.TabIndex = 6;
            this.centerSubnet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // centerName
            // 
            this.centerName.CanBeCleared = true;
            this.centerName.Location = new System.Drawing.Point(101, 89);
            this.centerName.Name = "centerName";
            this.centerName.ReadOnly = true;
            this.centerName.Size = new System.Drawing.Size(116, 20);
            this.centerName.TabIndex = 4;
            this.centerName.Tag = "clear";
            this.centerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // searchButton
            // 
            this.searchButton.CanBeCleared = false;
            this.searchButton.Location = new System.Drawing.Point(224, 276);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(104, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search By Code";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 352);
            this.Controls.Add(this.toolStrip1);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donor Center Info Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private DonorTextBox centerName;
        private System.Windows.Forms.TextBox searchEntryBox;
        private DonorTextBox centerSubnet;
        private System.Windows.Forms.Label centerNameLabel;
        private System.Windows.Forms.Label centerSubnetLabel;
        private System.Windows.Forms.Label centerPhoneLabel;
        private DonorTextBox centerPhone;
        private System.Windows.Forms.Label centerTypeLabel;
        private DonorTextBox centerType1;
        private System.Windows.Forms.Label centerExtLabel;
        private System.Windows.Forms.Label zebraLabel1;
        private System.Windows.Forms.Label zebraLabel2;
        private System.Windows.Forms.Label konicaLabel;
        private DonorTextBox centerExtension;
        private DonorButton zebraButton1;
        private DonorButton zebraButton2;
        private DonorButton konicaButton;
        private System.Windows.Forms.ToolStripMenuItem generateZebraConfigFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zB1GenConfig;
        private System.Windows.Forms.ToolStripMenuItem zB2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportAnIssueToolStripMenuItem;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchByNameEntry;
        private DonorButton searchByNameButton;
        private System.Windows.Forms.Label searchByNameLabel;
        private System.Windows.Forms.Label cneterCodeLabel;
        private DonorTextBox centerCodeBox;
        private System.Windows.Forms.ToolStripMenuItem clearWindowToolStripMenuItem;
        private DonorButton searchButton;
        private System.Windows.Forms.ToolStripMenuItem generatePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripPwGen;
        private System.Windows.Forms.ToolStripButton toolStripClearFields;
        private System.Windows.Forms.ToolStripButton toolStripExitButton;
        private System.Windows.Forms.ToolStripMenuItem generatePasswordListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.SaveFileDialog savePwFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

