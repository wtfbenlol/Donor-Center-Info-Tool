using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Donor_Center_Info_Tool
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            var db = new DonorButton();
            // sets up the auto complete text in the search by name entry box on init so we dont have to load it later. 
            // compares input prefixes to a list collection of center names pulled from the sqlite database
            var source = new AutoCompleteStringCollection();
            var sourceList = new ListData();
            source.AddRange(sourceList.PopulateAutoComplete().ToArray());
            searchByNameEntry.AutoCompleteCustomSource = source;
            Controls.Add(db);
            
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
                centerCodeBox.Text = dc.Code;
                
                    
                // change button text to that of matching zebra printer IP
                zebraButton1.Text = dc.Ip.Replace("x", "65");
                zebraButton2.Text = dc.Ip.Replace("x", "66");
                konicaButton.Text = dc.Ip.Replace("x", "72");

            }

            catch (ArgumentOutOfRangeException)
            {
                // show error dialog
                DialogResult = MessageBox.Show("You entered an invalid Center Code, try again", "Error: Invalid Center Code", MessageBoxButtons.OK);
            }

            catch (SQLiteException)
            {
                // show error dialog
                DialogResult = MessageBox.Show("You've entered something wrong. There are probably letters instead of a center code", "Error: Invalid Input", MessageBoxButtons.OK);
            }
        }
        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // check if entry field is blank, if blank, return
            if (searchEntryBox.Text.Length == 0) return;
            PopulateFields(searchEntryBox.Text);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void SearchByNameButton_Click(object sender, EventArgs e)
        {
            // check for empty search box, return if empty
            if (searchByNameEntry.Text.Length == 0) return;
            // new listdata object
            ListData ld = new ListData();
            // call ListData<> search by name
            string name = searchByNameEntry.Text;
            ld.CenterDataByName(name);
        }

        private void ZB1GenConfig_Click(object sender, EventArgs e)
        {
            // initalize new instance of the scraper class
            Scraper scrape = new Scraper();
            // check to see if zebra label is not empty
            if (zebraLabel2.Text.Length == 0) return;
            try
            {
                string url = @"http://" + zebraButton1.Text + @"/config.html";
                scrape.Scrape(url, zebraLabel1.Text, centerCodeBox.Text);
                scrape.ScrapePrinterStatus(url);

            }

            catch (WebException)
            {
                string url2 = @"http://" + zebraButton1.Text + @"/printer/config.html";
                scrape.Scrape(url2, zebraLabel1.Text, centerCodeBox.Text);
            }

        }

        private void ZB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // initalize new instance of the scraper class
            Scraper scrape = new Scraper();
            // check to see if zebra label is not empty
            if (zebraLabel2.Text.Length == 0) return;
            try
            {
                string url = @"http://" + zebraButton1.Text + @"/config.html";
                scrape.Scrape(url, zebraLabel2.Text, centerCodeBox.Text);
            }

            catch (WebException)
            {
                string url2 = @"http://" + zebraButton1.Text + @"/printer/config.html";
                scrape.Scrape(url2, zebraLabel2.Text, centerCodeBox.Text);
            }
        }

        private void ZebraButton1_Click(object sender, EventArgs e)
        {
            if (zebraButton1.Text.Length == 0) return;
            string ip = zebraButton1.Text;
            Process.Start("http://" + ip);
        }

        private void ZebraButton2_Click(object sender, EventArgs e)
        {
            if (zebraButton2.Text.Length == 0) return;
            string ip = zebraButton2.Text;
            Process.Start("http://" + ip);
        }

        private void KonicaButton_Click(object sender, EventArgs e)
        {
            if (konicaButton.Text.Length == 0) return;
            string ip = konicaButton.Text;
            Process.Start("http://" + ip);

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearFormElements()
        {
            // uses linq reflection to check control type for custom control, then clears the control if CanBeCleared == true
            foreach (var button in Controls.OfType<DonorButton>())
            {
                if (button.CanBeCleared)
                {
                    button.ResetText();
                }
            }

            foreach (var entry in Controls.OfType<DonorTextBox>())
            {
                if (entry.CanBeCleared)
                {
                    entry.ResetText();
                }
            }
        }

        private void ClearWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFormElements();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO
            // code for preferences window will go here
        }

        private void generatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            PasswordBox pwb = new PasswordBox();

            string password = Randomizer.GeneratePassword(3, 2, 2, 1);
            pwb.pwBoxTextBox.Text = password;
            
            foreach (Form f in Application.OpenForms)
            {
                if (f is PasswordBox)
                {
                    f.Focus();
                }

            }
            pwb.Show();
        }

        private void toolStripPwGen_Click(object sender, EventArgs e)
        {
            PasswordBox pwb = new PasswordBox();
            
            string password = Randomizer.GeneratePassword(3, 2, 2, 1);
            pwb.pwBoxTextBox.Text = password;
             
            foreach (Form f in Application.OpenForms)
            {
                if (f is PasswordBox)
                {
                    f.Focus();
                }

            }
            pwb.Show();
           
        }

        private void toolStripClearFields_Click(object sender, EventArgs e) => ClearFormElements();

        private void toolStripExitButton_Click(object sender, EventArgs e) => Application.Exit();

        private void generatePasswordListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void savePwFile_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Randomizer.GeneratePasswordFile(25);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Randomizer.GeneratePasswordFile(50);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Randomizer.GeneratePasswordFile(100);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}