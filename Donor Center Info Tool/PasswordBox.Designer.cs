namespace Donor_Center_Info_Tool
{
    partial class PasswordBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordBox));
            this.pwBoxTextBox = new System.Windows.Forms.TextBox();
            this.passwordBoxOK = new System.Windows.Forms.Button();
            this.passwordBoxCopyToCB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pwBoxTextBox
            // 
            this.pwBoxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwBoxTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pwBoxTextBox.Location = new System.Drawing.Point(43, 12);
            this.pwBoxTextBox.Name = "pwBoxTextBox";
            this.pwBoxTextBox.ReadOnly = true;
            this.pwBoxTextBox.Size = new System.Drawing.Size(204, 45);
            this.pwBoxTextBox.TabIndex = 0;
            this.pwBoxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordBoxOK
            // 
            this.passwordBoxOK.Location = new System.Drawing.Point(43, 79);
            this.passwordBoxOK.Name = "passwordBoxOK";
            this.passwordBoxOK.Size = new System.Drawing.Size(90, 23);
            this.passwordBoxOK.TabIndex = 1;
            this.passwordBoxOK.Text = "Generate New";
            this.passwordBoxOK.UseVisualStyleBackColor = true;
            this.passwordBoxOK.Click += new System.EventHandler(this.passwordBoxOK_Click);
            // 
            // passwordBoxCopyToCB
            // 
            this.passwordBoxCopyToCB.Location = new System.Drawing.Point(140, 79);
            this.passwordBoxCopyToCB.Name = "passwordBoxCopyToCB";
            this.passwordBoxCopyToCB.Size = new System.Drawing.Size(107, 23);
            this.passwordBoxCopyToCB.TabIndex = 2;
            this.passwordBoxCopyToCB.Text = "Copy to Clipboard";
            this.passwordBoxCopyToCB.UseVisualStyleBackColor = true;
            this.passwordBoxCopyToCB.Click += new System.EventHandler(this.passwordBoxCopyToCB_Click);
            // 
            // PasswordBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 128);
            this.Controls.Add(this.passwordBoxCopyToCB);
            this.Controls.Add(this.passwordBoxOK);
            this.Controls.Add(this.pwBoxTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PasswordBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Generate SOX Password";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox pwBoxTextBox;
        private System.Windows.Forms.Button passwordBoxOK;
        private System.Windows.Forms.Button passwordBoxCopyToCB;
    }
}