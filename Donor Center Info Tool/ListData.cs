using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Donor_Center_Info_Tool
{
    // abstraction that returns a dataset in the form of a list that can be used to populate fields in the form.
    internal class ListData
    {
        public List<string> CenterDataByCode(string center)
        {
            /* Note that this particular method is a little redundant and obtuse compared to the other
             * Search Methods in this class. This method will be refactored to inherent from the SeachDataBase()
             * method. But for now it works so i'm leaving it as a proof-of-concept */
             
            // build connection string
            var sql = "select * from Centers where Code=" + center;
            const string filename = @"C:\db\centers.db";
            var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
            // open the connection
            conn.Open();
            // Generate a new DataSet to be filled with the sql query results
            var ds = new DataSet();
            var da = new SQLiteDataAdapter(sql, conn);
            // use the SQLite DataAdapter to fill the DataSet
            da.Fill(ds);
            // Create a list to store the DataSet
            var rowData = new List<string>();
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
                var sql = $"Select Name, Code from Centers where Name like '{centerName}%'";
                const string filename = @"C:\db\centers.db";
                var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");

                conn.Open();

                var ds = new DataSet();
                var da = new SQLiteDataAdapter(sql, conn);

                da.Fill(ds);
                var centerData = new Dictionary<string, string>();

                foreach (DataTable table in ds.Tables)
                foreach (DataRow row in table.Rows)
                {
                    centerData.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString());
                }

                // if there is more than one key/value pair in centerData
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
            var sql = "select Name from Centers";
            const string filename = @"C:\db\centers.db";
            var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");
            // open the connection
            conn.Open();
            // Generate a new DataSet to be filled with the sql query results
            var ds = new DataSet();
            var da = new SQLiteDataAdapter(sql, conn);
            // use the SQLite DataAdapter to fill the DataSet
            da.Fill(ds);
            // Create a list to store the DataSet
            var rowData = new List<string>();
            // Loop through the dataset by table, then by row and fill List<rowData>
            foreach (DataTable table in ds.Tables)
            foreach (DataRow row in table.Rows)
                rowData.AddRange(row.ItemArray.Cast<string>());
            // return the list for use outside the method
            return rowData;
        }
    }
}