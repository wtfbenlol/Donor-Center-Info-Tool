using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Donor_Center_Info_Tool
{   // Center class is used to abstract donor center data into an organized class for populating form fields
    internal class DonorCenter
    {
        // the order of these properties is very important
        public string Name {get; set;}
        public string Ip { get; set; }
        public string Phone { get; set; }
        public string Code { get; set; }
        public string Type { get; set; }
        public string Ext { get; set; }

        // future properties //
        //public string Zb1Ip { get; set; }
        //public string Zb2Ip { get; set; }

        // declare read only list of PropertyInfo objects from class properties
        public readonly PropertyInfo[] PropertyList;

        // dump class properties into a PropertyList class
        public DonorCenter() => PropertyList = GetType().GetProperties();

        public Dictionary<PropertyInfo, string> PopulateProperties(string code)
        {
            
            ListData ld = new ListData();
            // add center data by center code to a list
            List<string> centerData = ld.CenterDataByCode(code);
            // iterate over list of properties and set them based on centerList
            // this depends on the fact that both list's elements are ordered so
            // the match up properly property => centerData list item
            int i = 0;
            foreach (PropertyInfo p in PropertyList)
            {
                p.SetValue(this, centerData[i]);
                i++;
            }
            // initialize new dictionary with key/value pairs of PropertyList objects and centerData Strings
            Dictionary<PropertyInfo, string> dcData =
                PropertyList.Zip(centerData, (k, v) => new {k, v}).ToDictionary(x => x.k, x => x.v);
            return dcData;
        }


    }
}
