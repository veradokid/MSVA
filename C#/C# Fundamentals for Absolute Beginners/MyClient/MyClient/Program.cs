using MyCodeLibrary;
using System;
using System.Collections.Generic;
//using System.IO;        //should be included in library only
using System.Linq;
//using System.Net;       //should be included in library only
using System.Text;
using System.Threading.Tasks;

namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Scrape myScrape = new Scrape();
            string value = myScrape.ScrapeWebpage("http://www.bjorkavaagbaat.net");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }


    //for debugging purposes...
    //public class Scrape
    //{
    //    public string ScrapeWebpage(string url)
    //    {
    //        return GetWebPage(url);
    //    }

    //    public string ScrapeWebpage(string url, string filepath)
    //    {
    //        string reply = GetWebPage(url);

    //        File.WriteAllText(filepath, reply);
    //        return reply;
    //    }

    //    private string GetWebPage(string url)
    //    //helpermethod to eliminate duplicate code
    //    {
    //        WebClient client = new WebClient();
    //        return client.DownloadString(url);
    //    }
    //}

}
