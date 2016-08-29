using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //ex 1

            //single line comment

            //int x;
            //int y;

            /*
             * several lines
             * of
             * comment
             * */

            //x = 7;
            //y = x + 3;

            //Console.WriteLine(y);
            //Console.ReadLine();


            //ex 2
            Console.WriteLine("What is your name?");
            Console.WriteLine("Type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.WriteLine("Type your last name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();

        }
    }
}
