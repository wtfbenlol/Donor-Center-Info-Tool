namespace Donor_Center_Info_Tool
{
    partial class ErrorReportingWindow
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
            this.titleBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.errDiscBox = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.errorSubmitButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.attachScreenShotButton = new System.Windows.Forms.Button();
            this.titleBox1.SuspendLayout();
            this.errDiscBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBox1
            // 
            this.titleBox1.Controls.Add(this.textBox1);
            this.titleBox1.Location = new System.Drawing.Point(33, 24);
            this.titleBox1.Name = "titleBox1";
            this.titleBox1.Size = new System.Drawing.Size(491, 51);
            this.titleBox1.TabIndex = 0;
            this.titleBox1.TabStop = false;
            this.titleBox1.Text = "Error Subject";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(475, 20);
            this.textBox1.TabIndex = 0;
            // 
            // errDiscBox
            // 
            this.errDiscBox.Controls.Add(this.textBox2);
            this.errDiscBox.Location = new System.Drawing.Point(33, 92);
            this.errDiscBox.Name = "errDiscBox";
            this.errDiscBox.Size = new System.Drawing.Size(491, 220);
            this.errDiscBox.TabIndex = 1;
            this.errDiscBox.TabStop = false;
            this.errDiscBox.Text = "Error Discription";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 19);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(475, 190);
            this.textBox2.TabIndex = 0;
            // 
            // errorSubmitButton
            // 
            this.errorSubmitButton.Location = new System.Drawing.Point(326, 332);
            this.errorSubmitButton.Name = "errorSubmitButton";
            this.errorSubmitButton.Size = new System.Drawing.Size(99, 36);
            this.errorSubmitButton.TabIndex = 2;
            this.errorSubmitButton.Text = "Submit";
            this.errorSubmitButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 332);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 36);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // attachScreenShotButton
            // 
            this.attachScreenShotButton.Location = new System.Drawing.Point(39, 332);
            this.attachScreenShotButton.Name = "attachScreenShotButton";
            this.attachScreenShotButton.Size = new System.Drawing.Size(99, 36);
            this.attachScreenShotButton.TabIndex = 5;
            this.attachScreenShotButton.Text = "Attach";
            this.attachScreenShotButton.UseVisualStyleBackColor = true;
            // 
            // ErrorReportingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 384);
            this.Controls.Add(this.attachScreenShotButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.errorSubmitButton);
            this.Controls.Add(this.errDiscBox);
            this.Controls.Add(this.titleBox1);
            this.Name = "ErrorReportingWindow";
            this.Text = "Report an Issue";
            this.titleBox1.ResumeLayout(false);
            this.titleBox1.PerformLayout();
            this.errDiscBox.ResumeLayout(false);
            this.errDiscBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox titleBox1;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox errDiscBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button errorSubmitButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button attachScreenShotButton;
    }
}