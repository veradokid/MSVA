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
            string content = File.ReadAllText(@"c:\Lesson22\Exampl.txt");
            Console.WriteLine(content);
            Console.ReadLine();

        }
    }
}
