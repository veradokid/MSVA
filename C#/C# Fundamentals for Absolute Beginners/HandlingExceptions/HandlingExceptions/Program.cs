using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"c:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                //throw;
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
