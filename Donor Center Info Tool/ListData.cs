using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace Donor_Center_Info_Tool
{
    class ListData
    {

        public List<string> CenterDataByCode(string center)
        {
            string sql = "select * from Centers where Code=" + center;
            const string filename = @"C:\Users\bdddy\Documents\GitHub\Donor-Center-Information-Tool\centers.db";
            var conn = new SQLiteConnection("Data Source=" + filename + ";Version=3;");

            conn.Open();
            DataSet ds = new DataSet();
            var da = new SQLiteDataAdapter(sql, conn);
            da.Fill(ds);

            List<string> rowData = new List<string>();

            foreach (DataTable table in ds.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (string item in row.ItemArray)
                    {
                        rowData.Add(item);
                    }
                }

            }
            return rowData;
        }
    }

}

