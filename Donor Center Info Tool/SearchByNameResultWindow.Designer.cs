using System.Collections;

namespace Donor_Center_Info_Tool
{
    partial class SearchByNameResultWindow
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
            this.nameSearchOk = new System.Windows.Forms.Button();
            this.nameSearchCancel = new System.Windows.Forms.Button();
            this.searchByNameListView = new System.Windows.Forms.ListView();
            this.searchByNameCenter = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchByNameCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // nameSearchOk
            // 
            this.nameSearchOk.Location = new System.Drawing.Point(27, 131);
            this.nameSearchOk.Name = "nameSearchOk";
            this.nameSearchOk.Size = new System.Drawing.Size(75, 23);
            this.nameSearchOk.TabIndex = 1;
            this.nameSearchOk.Text = "Ok";
            this.nameSearchOk.UseVisualStyleBackColor = true;
            this.nameSearchOk.Click += new System.EventHandler(this.nameSearchOk_Click);
            // 
            // nameSearchCancel
            // 
            this.nameSearchCancel.Location = new System.Drawing.Point(119, 131);
            this.nameSearchCancel.Name = "nameSearchCancel";
            this.nameSearchCancel.Size = new System.Drawing.Size(75, 23);
            this.nameSearchCancel.TabIndex = 2;
            this.nameSearchCancel.Text = "Cancel";
            this.nameSearchCancel.UseVisualStyleBackColor = true;
            this.nameSearchCancel.Click += new System.EventHandler(this.nameSearchCancel_Click);
            // 
            // searchByNameListView
            // 
            this.searchByNameListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.searchByNameCenter,
            this.searchByNameCode});
            this.searchByNameListView.FullRowSelect = true;
            this.searchByNameListView.GridLines = true;
            this.searchByNameListView.Location = new System.Drawing.Point(27, 12);
            this.searchByNameListView.Name = "searchByNameListView";
            this.searchByNameListView.Size = new System.Drawing.Size(270, 97);
            this.searchByNameListView.TabIndex = 3;
            this.searchByNameListView.UseCompatibleStateImageBehavior = false;
            this.searchByNameListView.View = System.Windows.Forms.View.Details;
            // 
            // searchByNameCenter
            // 
            this.searchByNameCenter.Text = "Center Name";
            this.searchByNameCenter.Width = 172;
            // 
            // searchByNameCode
            // 
            this.searchByNameCode.Text = "Center Code";
            this.searchByNameCode.Width = 87;
            // 
            // SearchByNameResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 177);
            this.Controls.Add(this.searchByNameListView);
            this.Controls.Add(this.nameSearchCancel);
            this.Controls.Add(this.nameSearchOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchByNameResultWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Name Search Results";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button nameSearchOk;
        private System.Windows.Forms.Button nameSearchCancel;
        public System.Windows.Forms.ListView searchByNameListView;
        private System.Windows.Forms.ColumnHeader searchByNameCenter;
        private System.Windows.Forms.ColumnHeader searchByNameCode;
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}