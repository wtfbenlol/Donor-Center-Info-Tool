using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

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

            ListData ld = new ListData();
            List<string> centerData = ld.CenterDataByCode(searchEntryBox.Text);

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


        private void zebraButton1_Click(object sender, EventArgs e)
        {
            string ip = zebraButton1.Text;
            System.Diagnostics.Process.Start("http://" + ip);

        }


        private void zebraButton2_Click(object sender, EventArgs e)
        {
            string ip = zebraButton2.Text;
            System.Diagnostics.Process.Start("http://" + ip);
        }


        private void konicaButton_Click(object sender, EventArgs e)
        {
            string ip = konicaButton.Text;
            System.Diagnostics.Process.Start("http://" + ip);
        }


        private void zB1GenConfig_Click(object sender, EventArgs e)
        {
            ListData ld = new ListData();
            List<string> centerData = ld.CenterDataByCode(searchEntryBox.Text);

            string url = @"http://" + centerData[1].Replace("x", "65") + @"/config.html";
            Scraper s = new Scraper();
            s.Scrape(url);
        }


        private void zB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListData ld = new ListData();
            List<string> centerData = ld.CenterDataByCode(searchEntryBox.Text);
            try
            {
                string url = @"http://" + centerData[1].Replace("x", "66") + @"/config.html";
                Scraper s = new Scraper();
                s.Scrape(url);
            }
            catch (System.Net.WebException err)
            {

                var res = (System.Net.HttpWebResponse) err.Response;
                if (res.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    string url = @"http://" + centerData[1].Replace("x", "66") + @"/printer/config.html";
                    Scraper s = new Scraper();
                    s.Scrape(url);
                }

            }
            
        }
    }
  }

