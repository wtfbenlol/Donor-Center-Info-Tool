using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;


namespace Donor_Center_Info_Tool
{
    class Scraper
    {
        public string Scrape(string url)
        {
            var document = new HtmlDocument();
            string x = "";
            using (var client = new WebClient())
            {
                
                var page = client.DownloadString(url);
                document.LoadHtml(page);
            }

            foreach (var node in document.DocumentNode.SelectNodes("//pre"))
            {
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.Create(desktop + @"\zebra.txt").Close();
                File.WriteAllText(desktop + @"\zebra.txt", node.InnerText);
                //Console.WriteLine(node);
            }
            return x;
        }
    }
}
