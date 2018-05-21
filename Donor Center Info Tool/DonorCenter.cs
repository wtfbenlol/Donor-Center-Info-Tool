using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donor_Center_Info_Tool
{   // Center class is used to abstract donor center data into an organized class for populating form fields
    internal class DonorCenter
    {
        // the order of these properties is very important
        public string Donor_Center {get; set;}
        public string FriendlyName {get; set;}
        public string Subnet { get; set; }
        public string Company { get; set; }
        public string CenterCode { get; set; }
        public string Phone { get; set; }
        public string DistPoint1 { get; set; }
        public string DistPoint2 { get; set; }
        public string PostAddr { get; set; }
        public string Extension { get; set; }

       

        // future properties //
        //public string Zb1Ip { get; set; }
        //public string Zb2Ip { get; set; }

        // declare read only list of PropertyInfo objects from class properties
        public readonly PropertyInfo[] PropertyList;

        // dump class properties into a PropertyList class
        public DonorCenter() => PropertyList = GetType().GetProperties();



        public string FormatSubnetForPrinter(string addr, string printer)
        {

            var bytes = IPAddress.Parse(addr).GetAddressBytes();

            switch (printer.ToLower())
            {
                    case "zb1":
                        bytes[3] = 65;
                        break;

                    case "zb2":
                        bytes[3] = 66;
                        break;

                    case "konica":
                        bytes[3] = 72;
                        break;
                    
                    case "reception":
                        bytes[3] = 67;
                        break;
            }

            IPAddress ip = new IPAddress(bytes);
            return ip.ToString();
        }

        public bool PingDistPoint(string DistPoint)
        {
            bool status = false;
            // holds return status string
            string returnMEssage = string.Empty;
            // ip address instance
            try
            {
                IPAddress ip = Dns.GetHostEntry(DistPoint).AddressList.First();



                // ping options (ttl = 128, don't fragment)
                PingOptions pingOptions = new PingOptions(128, true);
                // new instance of the ping class
                Ping ping = new Ping();
                // new buffer for ping
                byte[] buffer = new byte[32];

                // create an instance of the ping reply class with out options as overloads
                PingReply pr = ping.Send(ip, 1000, buffer, pingOptions);

                // check for a null response

                if (pr != null)
                {
                    switch (pr.Status)
                    {
                        // if we get a reply return true
                        case IPStatus.Success:
                            status = true;
                            break;

                        // if we timeout, return false
                        case IPStatus.TimedOut:
                            status = false;
                            break;

                    }

                }
            }
            catch (SocketException)
            {
                MessageBox.Show("Distribution Point appears to be offline", "Warning");

            }

            return status;
        }

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
                // the zip function takes 2 lists and uses arg[0] and the key and the
                // arg[1] as the value and returns a dictionary object
                PropertyList.Zip(centerData, (k, v) => new {k, v}).ToDictionary(x => x.k, x => x.v);
            return dcData;
        }


    }
}
