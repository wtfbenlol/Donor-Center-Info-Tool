using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace Donor_Center_Info_Tool
{
    // abstraction that returns a dataset in the form of a list that can be used to populate fields in the form.
    // also updates the local .db database file to match a curated version hosted on a fileshare
    internal class ListData
    {
        // these strings should never change locally
        // local folder with most curernt db version
        internal string udir = @"\\micv3b\is\DSS\NASD\Utilities\DCIT\centers_updated.db";
        // destination directory
        internal string ddir = @"c:\db\centers_updated.db";

        public List<string> CenterDataByCode(string center)
        {
            /* Note that this particular method is a little redundant and obtuse compared to the other
             * Search Methods in this class. This method will be refactored to inherent from the SeachDataBase()
             * method. But for now it works so i'm leaving it as a proof-of-concept */
             
            // build connection string
            string sql = "select * from Centers where CenterCode=" + center;
            const string filename = @"c:\db\centers_updated.db";
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
            // open the connection
            conn.Open();
            // Generate a new DataSet to be filled with the sql query results
            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);
            // use the SQLite DataAdapter to fill the DataSet
            da.Fill(ds);
            // Create a list to store the DataSet
            List<string> rowData = new List<string>();
            // Loop through the dataset by table, then by row and fill List<rowData>
            foreach (DataTable table in ds.Tables)
            foreach (DataRow row in table.Rows)
                rowData.AddRange(row.ItemArray.Cast<string>());
            // return the list for use outside the method
            return rowData;

        }

        public void CenterDataByName(string centerName)
        {
          /* functionality is essentially the same as CenterDataByCode however we are using the sqlike LIKE
             operator which functions like regex in that it returns any record that matches the string before
             the % symbol. If there is more than one results, results (center name and center code) are displayed 
             in a ListView Form that the user can then select a single center from. No return value needed as results
             are used to call the CenterDataByCode() function*/

            try
            {
                var sql = $"Select DonorCenter, CenterCode from Centers where DonorCenter like '{centerName}%'";
                const string filename = @"c:\db\centers_updated.db";
                var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");

                conn.Open();

                DataSet ds = new DataSet();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);

                da.Fill(ds);
                var centerData = new Dictionary<string, string>();

                foreach (DataTable table in ds.Tables)
                foreach (DataRow row in table.Rows)
                {
                    centerData.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString());
                }

                // if there is less than one key/value pair in centerData we go ahead and populate the window.
                // there would be no reason to pick one center from a list
                if (centerData.Count > 1)
                {
                    // append the key/value pairs into the SearchByNameResultsWindow() ListView
                    SearchByNameResultWindow nameSearch = new SearchByNameResultWindow();
                    foreach (KeyValuePair<string, string> row in centerData)
                    {
                        nameSearch.searchByNameListView.Items.Add(new ListViewItem(new[] {row.Key, row.Value}));
                    }

                    nameSearch.ShowInTaskbar = false;
                    // show the window for center selection
                    nameSearch.ShowDialog();
                }
                else
                {
                    // automatically fill form if there is only one key/value pair in centerData
                    var principalform = Application.OpenForms.OfType<MainWindow>().FirstOrDefault();
                    // case the only value in centerData to a list
                    List<string> value = centerData.Values.ToList();
                    // if the main form is active/not null populate fields
                    principalform?.PopulateFields(value[0]);
                }
            }

            catch (ArgumentOutOfRangeException)
            {
                // umbrella handling that catches any error that came be raised by searching with this form

                string caption = "Whoops! Something isn't right =[";
                string msg = "Search yielded no results, please modify search parameters";
                var buttons = MessageBoxButtons.OK;
                MessageBox.Show(msg, caption, buttons);
            }

        }

        public List<string> PopulateAutoComplete()
        {
              
            // build connection string
            string sql = "select DonorCenter from Centers";
            const string filename = @"c:\db\centers_updated.db";
            SQLiteConnection conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");

            // open the connection
            ;conn.Open();
            // Generate a new DataSet to be filled with the sql query results

            DataSet ds = new DataSet();
            SQLiteDataAdapter da = new SQLiteDataAdapter(sql, conn);

            // use the SQLite DataAdapter to fill the DataSet
            da.Fill(ds);

            // Create a list to store the DataSet
            List<string> rowData = new List<string>();

            // Loop through the dataset by table, then by row and fill List<rowData>
            foreach (DataTable table in ds.Tables)
            foreach (DataRow row in table.Rows)
                rowData.AddRange(row.ItemArray.Cast<string>());

            // return the list for use outside the method
            return rowData;
        }

        public void UpdateDataBase(string path)
        { 
            // lets make sure the directory exists
            string dpath = @"c:\db";
            if(!Directory.Exists(dpath))
            {
                Directory.CreateDirectory(dpath);
            }
            
            // does the file exist? will be expanded to check md5 checksum for changes in file on startup
            

            if(!File.Exists(path)) {
                // if not, copy the file to the local directory
                File.Copy(udir, ddir, true);
                // alert the user to the update
                MessageBox.Show("1 file(s) copied successfully",
                                "Local Data Base Updated Automatically",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else {
                // if the file exsists, compare their hashes converted
                // to strings, if the return value is 0,
                // the strings match, any non zero intergers mean the files hashes do
                // not match
                if (!CheckMD5(udir, ddir)) {

                    // copy the db file to the local c drive, overwriting if needed
                    File.Copy(udir, ddir, true);
                    // alert the user to the update
                    MessageBox.Show("1 file(s) copied successfully",
                                    "Local Data Base Updated Automatically",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }               
            }
            
        }

        static bool CheckMD5(string path1, string path2) {
            // checks 2 strings and returns a bool value
            // if the return value is anything but 0, the
            // md5 is mismatched and requires an updated file
            int result = String.Compare(GetMd5Hash(path1), GetMd5Hash(path2), true);
            if (result != 0) {
                return false;
            }
            else {
                return true;
            }
            
        }

        static string GetMd5Hash(string path) {
            // create a new instance of MD5 
            using (MD5 md5 = MD5.Create()) {
                // open the source database file for reading into filestream
                using (FileStream stream = File.OpenRead(path)) {
                    // map the bytes returned to an array, return
                    // and convert them to an easy-to-read string
                    byte[] mData = md5.ComputeHash(stream);
                    return BitConverter.ToString(mData).Replace("-", "").ToLowerInvariant();
                }
            }
        }
    }
}