﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyCodeLibrary
{
    public class Ccrape
    {
        public string ScrapeWebpage(string url)
        {
            WebClient client = new WebClient();
            return client.DownloadString(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebPage(string url)
        {

        }
    }
}
