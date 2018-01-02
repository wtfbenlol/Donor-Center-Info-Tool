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
            SearchByNameResultWindow search = new SearchByNameResultWindow();
        }

        public void PopulateFields(string centercode)
        {

            try
            {
                var ld = new ListData();
                var centerData = ld.CenterDataByCode(centercode);

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
    

        private void button1_Click(object sender, EventArgs e)
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
            if (searchByNameEntry.Text.ToString().Length != 0)
            { 
            ListData ld = new ListData();
            string centerName = searchByNameEntry.Text;
            
            ld.CenterDataByName(centerName);
            }
        }

        private void zB1GenConfig_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void zB2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void zebraButton1_Click(object sender, EventArgs e)
        {
            if (zebraButton1.Text.Length != 0)
            {
                string ip = zebraButton1.Text;
                Process.Start("http://" + ip);
            }
        }

        private void zebraButton2_Click(object sender, EventArgs e)
        {
            if (zebraButton2.Text.Length != 0)
            {
                string ip = zebraButton2.Text;
                Process.Start("http://" + ip);
            }
        }

        private void konicaButton_Click(object sender, EventArgs e)
        {
            if (konicaButton.Text.Length != 0)
            {
                string ip = konicaButton.Text;
                Process.Start("http://" + ip);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}