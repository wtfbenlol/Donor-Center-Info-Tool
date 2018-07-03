using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donor_Center_Info_Tool
{
    public partial class SearchWiki : Form
    {
        public SearchWiki()
        {
            InitializeComponent();
        }

        private void WikiSeachSubmit_Click(object sender, EventArgs e)
        {
            // https://confluence.grifols.com/dosearchsite.action?queryString="seach string here"
            string searchText = WikiSearchTextBox.Text.ToString();
            Process.Start("https://confluence.grifols.com/dosearchsite.action?queryString=" + searchText);
            SearchWiki.ActiveForm.Close();
        }

        private void WikiSearchCancel_Click(object sender, EventArgs e)
        {
            SearchWiki.ActiveForm.Close();
        }
    }
}
