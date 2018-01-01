using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Donor_Center_Info_Tool
{
    //abstraction that returns a dataset in the form of a list that can be used to populate fields in the form.
    internal class ListData
    {
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
    }
}