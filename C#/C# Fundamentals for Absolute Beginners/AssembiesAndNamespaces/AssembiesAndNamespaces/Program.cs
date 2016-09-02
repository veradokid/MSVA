using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace AssembiesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //source snippet #1: https://msdn.microsoft.com/en-us/library/8bh11f1k.aspx
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";

            //System.IO.File.WriteAllText(@"C:\Lesson17\\WriteText.txt", text);
            File.WriteAllText(@"C:\MSVA\WriteText.txt", text); //included nameespace in using
                                                               // end snippet #1


            //source snippet #2: https://msdn.microsoft.com/en-us/library/fhd1f0sw(v=vs.110).aspx
            //WebClient is not initially recognized
            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            //end snippet #2

            //try writing to file
            File.WriteAllText(@"C:\MSVA\MSDNText.txt", reply); 
                                                               

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }//Main
    }//Program
}
