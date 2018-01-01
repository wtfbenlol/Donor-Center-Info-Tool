using System;
using System.IO;
using System.Net;
using HtmlAgilityPack;

namespace Donor_Center_Info_Tool
{
    internal class Scraper
    {
        public void Scrape(string url)
        {
            var document = new HtmlDocument();

            using (var client = new WebClient())
            {
                var page = client.DownloadString(url);
                document.LoadHtml(page);
            }

            foreach (var node in document.DocumentNode.SelectNodes("//pre"))
            {
                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                File.Create(desktop + @"\zebra.txt").Close();
                File.WriteAllText(desktop + @"\zebra.txt", node.InnerText);
                //Console.WriteLine(node);
            }
        }
    }
}