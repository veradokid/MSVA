using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ScrapeLibrary
{
    public class Scrape
    {
        public string ScrapeWebpage(string url)
        {
            return GetWebPage(url);
        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebPage(url);

            File.WriteAllText(filepath, reply);
            return reply;
        }

        private string GetWebPage(string url)
        //helpermethod to eliminate duplicate code
        {
            WebClient client = new WebClient();
            string content = client.DownloadString(url);
            content += "\n Thats all Folks!";
            return content;
        }
    }


}
