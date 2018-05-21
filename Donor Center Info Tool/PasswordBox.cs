using System;
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
            string password = Randomizer.GenerateFixedCryptoPassword(8);
            pwBoxTextBox.Text = password;
        }

        private void passwordBoxCopyToCB_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(pwBoxTextBox.Text);
        }
    }
}
