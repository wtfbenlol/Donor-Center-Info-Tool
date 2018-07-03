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
        // initialize blank DonorCenter() class for use in this form
        
        public MainWindow()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(SearchEntryBox_KeyDown);
            this.KeyDown += new KeyEventHandler(SearchByNameEntry_KeyDown);
            var db = new DonorButton();
            var sourceList = new ListData();
            //update the database files
            string ddir = sourceList.ddir;
            sourceList.UpdateDataBase(ddir);
            // sets up the auto complete text in the search by name entry box on init so we dont have to load it later. 
            // compares input prefixes to a list collection of center names pulled from the sqlite database
            var source = new AutoCompleteStringCollection();            
            // pass the dataset to the autofill method
            source.AddRange(sourceList.PopulateAutoComplete().ToArray());
            searchByNameEntry.AutoCompleteCustomSource = source;
            Controls.Add(db);         
        }

        readonly DonorCenter dc = new DonorCenter();

        public void PopulateFields(string centercode)
        {
            try
            {   
                // initialize dc data 
                dc.PopulateProperties(centercode);
                // assigned data to fields
                centerName.Text = dc.FriendlyName;
                centerSubnet.Text = dc.Subnet;
                centerPhone.Text = dc.Phone;
                donorExtBox1.Text = dc.FormatExtension(dc.Subnet);
                centerType1.Text = dc.Company;
                centerLocation.Text = dc.Donor_Center;
                centerCodeBox.Text = dc.CenterCode;
                centerAddrBox.Text = dc.PostAddr;

                // generate distribution point 
                DistPoint1Label.Text = dc.DistPoint1.ToUpper();
                DistPointStatus1.BackColor = Color.Red;


                // ping distribution points and set status box to green if the distribution point is online. 

                if (dc.PingDistPoint(dc.DistPoint1))
                {
                    DistPointStatus1.BackColor = Color.Lime;
                }


                // change button text to that of matching zebra printer IP
                zebraButton1.Text = dc.FormatSubnetForPrinter(dc.Subnet, "zb1");
                zebraButton2.Text = dc.FormatSubnetForPrinter(dc.Subnet, "zb2");
                konicaButton.Text = dc.FormatSubnetForPrinter(dc.Subnet, "konica");
                receptionButton.Text = dc.FormatSubnetForPrinter(dc.Subnet, "reception");

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
            
            // check to see if zebra label is not empty
            if (zebraLabel1.Text.Length == 0) return;
            Scraper scrape = new Scraper();
            try
            {
                string url = @"http://" + zebraButton1.Text + @"/config.html";
                scrape.Scrape(url, zebraLabel1.Text, centerCodeBox.Text);
                scrape.ScrapePrinterStatus(url);

            }

            catch (System.ArgumentException)
            {
                MessageBox.Show("Please select a center first", "Error");
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
            
            // check to see if zebra label is not empty
            if (zebraLabel2.Text.Length == 0) return;
            Scraper scrape = new Scraper();
            try
            {
                string url = @"http://" + zebraButton1.Text + @"/config.html";
                scrape.Scrape(url, zebraLabel2.Text, centerCodeBox.Text);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Please select a center first", "Error");
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

            foreach (var entry in Controls.OfType<DonorEntry>())
            {
                if (entry.CanBeCleared)
                {
                    entry.ResetText();
                }
            }

            // resets distribution point elements
            DistPoint1Label.ResetText();


            DistPointStatus1.BackColor = Color.Empty;

            // reset address box text
            centerAddrBox.ResetText();
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

            string password = Randomizer.GenerateFixedCryptoPassword(8);
            pwBoxTextBoxMainForm.Text = password;
            
        }

        private void toolStripPwGen_Click(object sender, EventArgs e)
        {
            PasswordBox pwb = new PasswordBox();
            
            string password = Randomizer.GenerateFixedCryptoPassword(8);
            pwb.pwBoxTextBox.Text = password;
             
            foreach (Form f in Application.OpenForms)
           {
                if (f is PasswordBox)
                {
                    f.Focus();
                }

            }
            pwb.ShowDialog();
           
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

        private void DistPointGB_Enter(object sender, EventArgs e)
        {
            // not needed will remove at later date
        }

        private void SearchEntryBox_KeyDown(object sender, KeyEventArgs e)
        {
  
        if (e.KeyCode == Keys.Enter) {
            //PopulateFields(searchEntryBox.Text);
            searchButton.PerformClick();
            // e.Handled = false;
            }
        }

        private void SearchByNameEntry_KeyDown(object sender, KeyEventArgs e)
        {
  
        if (e.KeyCode == Keys.Enter) {
            //PopulateFields(searchEntryBox.Text);
            searchByNameButton.PerformClick();
            // e.Handled = false;
            }
        }

        private void GenPwButton_Click(object sender, EventArgs e)
        {
            string password = Randomizer.GenerateFixedCryptoPassword(8);
            pwBoxTextBoxMainForm.Text = password;
        }

        private void receptionButton_Click(object sender, EventArgs e)
        {
            if (receptionButton.Text.Length == 0) return;
            string ip = receptionButton.Text;
            Process.Start("http://" + ip);
        }

        private void reportAnIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ErrorMail em = new ErrorMail();
            em.SendMail();
        }

        private void searchWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchWiki sw = new SearchWiki();
            sw.Show();
        }
    }
}