namespace Donor_Center_Info_Tool
{
    partial class SearchWiki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchWiki));
            this.WikiSearchTextBox = new System.Windows.Forms.TextBox();
            this.WikiSearchSubmit = new System.Windows.Forms.Button();
            this.WikiSearchCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WikiSearchTextBox
            // 
            this.WikiSearchTextBox.Location = new System.Drawing.Point(29, 28);
            this.WikiSearchTextBox.Name = "WikiSearchTextBox";
            this.WikiSearchTextBox.Size = new System.Drawing.Size(358, 20);
            this.WikiSearchTextBox.TabIndex = 0;
            // 
            // WikiSearchSubmit
            // 
            this.WikiSearchSubmit.Location = new System.Drawing.Point(176, 73);
            this.WikiSearchSubmit.Name = "WikiSearchSubmit";
            this.WikiSearchSubmit.Size = new System.Drawing.Size(102, 23);
            this.WikiSearchSubmit.TabIndex = 1;
            this.WikiSearchSubmit.Text = "Search";
            this.WikiSearchSubmit.UseVisualStyleBackColor = true;
            this.WikiSearchSubmit.Click += new System.EventHandler(this.WikiSeachSubmit_Click);
            // 
            // WikiSearchCancel
            // 
            this.WikiSearchCancel.Location = new System.Drawing.Point(284, 73);
            this.WikiSearchCancel.Name = "WikiSearchCancel";
            this.WikiSearchCancel.Size = new System.Drawing.Size(103, 23);
            this.WikiSearchCancel.TabIndex = 2;
            this.WikiSearchCancel.Text = "Cancel";
            this.WikiSearchCancel.UseVisualStyleBackColor = true;
            this.WikiSearchCancel.Click += new System.EventHandler(this.WikiSearchCancel_Click);
            // 
            // SearchWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 123);
            this.Controls.Add(this.WikiSearchCancel);
            this.Controls.Add(this.WikiSearchSubmit);
            this.Controls.Add(this.WikiSearchTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchWiki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Confluence";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WikiSearchTextBox;
        private System.Windows.Forms.Button WikiSearchSubmit;
        private System.Windows.Forms.Button WikiSearchCancel;
    }
}