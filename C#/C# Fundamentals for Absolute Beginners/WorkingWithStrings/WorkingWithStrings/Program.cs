using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myStiring = "My \"so-called\" life";
            //string myString = "What if I need a \nnew line?";
            //string myString = "Go to your c:\\drive";
            //string myString = @"Go to your c:\drive";

            //string myString = string.Format("{1} = {0}", "First", "Second");
            //string myString = string.Format("{0:C}", 123.45);   //Will be formated as currency
            //string myString = string.Format("{0:N}", 1234567890);   //format as number (local format)
            //string myString = string.Format("{0:P}", .123);   //format as percent (1 = 100%)
            //string myString = string.Format("Phone Number {0:(###) ###-####}", 123456789012); //will not cope with input of more characters

            //manipulate strings
            //string myString = " That summer we took threes across the board  ";

            //myString = myString.Substring(6);
            //myString = myString.Substring(6, 14);
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14);
            //myString = string.Format("Lenth before: {0} -- Length after: {1}",
            //    myString.Length,
            //    myString.Trim().Length);

            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            //Will be more efficient
            StringBuilder myString = new StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
