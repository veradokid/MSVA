using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();       //invoke method by adding "()".
        }

        private static void HelloWorld()
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
        }

    }
}
