﻿using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;

namespace Donor_Center_Info_Tool
{
    internal class Scraper
    {
        public void Scrape(string url, string zebraname, string code)
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
                File.Create(desktop + @"\" + code + zebraname +".txt").Close();
                File.WriteAllText(desktop + @"\" + code + zebraname +".txt", node.InnerText);
                //Console.WriteLine(node);
            }
        }
        // WIP, not to be used
        public void ScrapePrinterStatus(string url)
        {
            var document = new HtmlDocument();

            using (var client = new WebClient())
            {
                var page = client.DownloadString(url);
                document.LoadHtml(page);
            }
            
            
            foreach (var node in document.DocumentNode.SelectNodes("//body"))
            {

                var desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string fname = desktop + @"\scrapetext.txt";
                Console.WriteLine(node.InnerText);

                //File.Create(fname).Close();                
                //File.WriteAllText(fname, h3.InnerText);

            }
        }
    }
}