using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donor_Center_Info_Tool
{
    public partial class PasswordBox : Form
    {
        public PasswordBox()
        {
            InitializeComponent();
        }

        private void passwordBoxOK_Click(object sender, EventArgs e)
        {
            string password = Randomizer.GeneratePassword(2, 2, 2, 2);
            pwBoxTextBox.Text = password;
        }

        private void passwordBoxCopyToCB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwBoxTextBox.Text);
        }
    }
}
