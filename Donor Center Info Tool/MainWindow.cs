using System;
using System.Data.SQLite;
using System.Diagnostics;
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
    }
}