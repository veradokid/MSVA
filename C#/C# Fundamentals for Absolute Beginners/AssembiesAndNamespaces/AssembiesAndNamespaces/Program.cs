using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AssembiesAndNamespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "A class is the most powerful data type in C#. Like a structure, " +
                           "a class defines the data and behavior of the data type. ";

            //System.IO.File.WriteAllText(@"C:\Lesson17\\WriteText.txt", text);
            File.WriteAllText(@"C:\MSVA\WriteText.txt", text); //included nameespace in using

            Console.WriteLine("Hello World");
            Console.ReadLine();
        }//Main
    }//Program
}
