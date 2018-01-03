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
    public partial class SearchByNameResultWindow : Form, IEnumerable<KeyValuePair<string, string>>
    {
        
        public SearchByNameResultWindow()
        {
            InitializeComponent();

        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private void nameSearchOk_Click(object sender, EventArgs e)
        {
            var principalform = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
            string value = searchByNameListView.SelectedItems[0].SubItems[1].Text;
            if (principalform != null) principalform.PopulateFields(value);
            ActiveForm.Close();
        }

        private void nameSearchCancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
