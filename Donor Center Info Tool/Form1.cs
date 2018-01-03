using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Windows.Forms;

namespace Donor_Center_Info_Tool
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent(); 
        }

        // initialize blank DonorCenter() class for use in this form
        readonly DonorCenter dc = new DonorCenter();

        public void PopulateFields(string centercode)
        {
            try
            {               
                dc.PopulateProperties(centercode);
                // assigned data to fields
                centerName.Text = dc.Name;
                centerSubnet.Text = dc.Ip;
                centerPhone.Text = dc.Phone;
                centerType1.Text = dc.Type;
                centerExtension.Text = dc.Ext;

                // change button text to that of matching zebra printer IP
                zebraButton1.Text = dc.Ip.Replace("x", "65");
                zebraButton2.Text = dc.Ip.Replace("x", "66");
                konicaButton.Text = dc.Ip.Replace("x", "72");
            }

            catch (ArgumentOutOfRangeException)
            {
                var wrongChoice = "You entered an invalid Center Code, try again";
                var caption = "Error: Invalid Center Code";
                var buttons = MessageBoxButtons.OK;
                // show error dialog
                DialogResult = MessageBox.Show(wrongChoice, caption, buttons);
            }

            catch (SQLiteException)
            {
                //Console.WriteLine(sqlerr);
                var invalidInput =
                    "You've entered something wrong. There is probably a letter insead of a center code";
                var caption = "Error: Invalid Input";
                var butts = MessageBoxButtons.OK;
                // show error dialog
                DialogResult = MessageBox.Show(invalidInput, caption, butts);
            }
        }
    
        private void searchButton_Click(object sender, EventArgs e)
        {
            PopulateFields(searchEntryBox.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void searchByNameButton_Click(object sender, EventArgs e)
        {
            // check for empty search box, return if empty
            if (searchByNameEntry.Text.Length == 0) return;
            // new listdata object
            ListData ld = new ListData();
            // call ListData<> search by name
            string name = searchByNameEntry.Text;
            ld.CenterDataByName(name);
        }

        private void zB1GenConfig_Click(object sender, EventArgs e)
        {
            // this was originally written and finished however it was somehow deleted =[
            throw new NotImplementedException();
        }

        private void zB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // this was originally written and finished however it was somehow deleted =[
            throw new NotImplementedException();
        }

        private void zebraButton1_Click(object sender, EventArgs e)
        {
            if (zebraButton1.Text.Length == 0) return;
            string ip = zebraButton1.Text;
            Process.Start("http://" + ip);
        }

        private void zebraButton2_Click(object sender, EventArgs e)
        {
            if (zebraButton2.Text.Length == 0) return;
            string ip = zebraButton2.Text;
            Process.Start("http://" + ip);
        }

        private void konicaButton_Click(object sender, EventArgs e)
        {
            if (konicaButton.Text.Length == 0) return;
            string ip = konicaButton.Text;
            Process.Start("http://" + ip);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}