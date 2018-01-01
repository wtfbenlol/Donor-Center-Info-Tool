using System;
using System.Data.SQLite;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;

namespace Donor_Center_Info_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var ld = new ListData();
                var centerData = ld.CenterDataByCode(searchEntryBox.Text);

                // assigned data to fields
                centerName.Text = centerData[0];
                centerSubnet.Text = centerData[1];
                centerPhone.Text = centerData[2];
                centerType1.Text = centerData[4];
                centerExtension.Text = centerData[5];

                // change button text to that of matching zebra printer IP
                zebraButton1.Text = centerData[1].Replace("x", "65");
                zebraButton2.Text = centerData[1].Replace("x", "66");
                konicaButton.Text = centerData[1].Replace("x", "72");
            }

            catch (ArgumentOutOfRangeException)
            {
                var wrongChoice = "You entered an invalid Center Code, try again";
                var caption = "Error: Invalid Center Code";
                var buttons = MessageBoxButtons.OK;

                DialogResult = MessageBox.Show(wrongChoice, caption, buttons);
            }

            catch (SQLiteException)
            {
                //Console.WriteLine(sqlerr);
                var invalidInput =
                    "You've entered something wrong. There is probably a letter insead of a center code";
                var caption = "Error: Invalid Input";

                var butts = MessageBoxButtons.OK;

                DialogResult = MessageBox.Show(invalidInput, caption, butts);
            }
        }


        private void zebraButton1_Click(object sender, EventArgs e)
        {
            var ip = zebraButton1.Text;
            Process.Start("http://" + ip);
        }


        private void zebraButton2_Click(object sender, EventArgs e)
        {
            var ip = zebraButton2.Text;
            Process.Start("http://" + ip);
        }


        private void konicaButton_Click(object sender, EventArgs e)
        {
            var ip = konicaButton.Text;
            Process.Start("http://" + ip);
        }


        private void zB1GenConfig_Click(object sender, EventArgs e)
        {
            var ld = new ListData();
            var centerData = ld.CenterDataByCode(searchEntryBox.Text);

            var url = @"http://" + centerData[1].Replace("x", "65") + @"/config.html";
            var s = new Scraper();
            s.Scrape(url);
        }


        private void zB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ld = new ListData();
            var centerData = ld.CenterDataByCode(searchEntryBox.Text);
            try
            {
                var url = @"http://" + centerData[1].Replace("x", "66") + @"/config.html";
                var s = new Scraper();
                s.Scrape(url);
            }
            catch (WebException err)
            {
                var res = (HttpWebResponse) err.Response;
                if (res.StatusCode == HttpStatusCode.NotFound)
                {
                    var url = @"http://" + centerData[1].Replace("x", "66") + @"/printer/config.html";
                    var s = new Scraper();
                    s.Scrape(url);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
}