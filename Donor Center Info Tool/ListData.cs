using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;

namespace Donor_Center_Info_Tool
{
    //abstraction that returns a dataset in the form of a list that can be used to populate fields in the form.
    internal class ListData
    {

        public DataSet SearchDataBase(string query)
        {
            var sql = $"Select Name, Code from Centers where Name like '{query}%'";

            const string filename = @"C:\db\centers.db";
            var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");

            conn.Open();

            var ds = new DataSet();
            var da = new SQLiteDataAdapter(sql, conn);
            da.Fill(ds);
            return ds;
        }


        public List<string> CenterDataByCode(string center)
        {
            var sql = "select * from Centers where Code=" + center;
            const string filename = @"C:\db\centers.db";
            var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");

            conn.Open();
            var ds = new DataSet();
            var da = new SQLiteDataAdapter(sql, conn);
            da.Fill(ds);
            
            var rowData = new List<string>();

            foreach (DataTable table in ds.Tables)
            foreach (DataRow row in table.Rows)
            foreach (string item in row.ItemArray)
                rowData.Add(item);

            return rowData;
        }

        public void CenterDataByName(string centerName)
        {

            var ds = SearchDataBase(centerName);

            var centerData = new Dictionary<string, string>();

            foreach (DataTable table in ds.Tables)
            foreach (DataRow row in table.Rows)
            {
                centerData.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString());
            }

            SearchByNameResultWindow nameSearch = new SearchByNameResultWindow();

            foreach (KeyValuePair<string, string> row in centerData)
            {
                nameSearch.searchByNameListView.Items.Add(new ListViewItem(new string[] {row.Key, row.Value}));

            }

            nameSearch.ShowInTaskbar = false;
            nameSearch.ShowDialog();


        }
    }
}