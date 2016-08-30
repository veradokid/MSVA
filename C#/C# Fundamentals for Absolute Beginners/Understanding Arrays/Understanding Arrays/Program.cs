using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Understanding_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ex 1
            int[] numbers = new int[5];     //declare the array

            //set values
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;
            //numbers[5] = 42;    //will not run bc. "Array-Out-Of-Bounds"


            //access values inside elements
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);      //.length

            Console.ReadLine();
            */

            //ex 2
            //the compiler will figure out how many elements
            int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };     //array of integers
            string[] names = new string[] { "ole", "dole", "doffen" };  //array of strings

            /*
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
            */

            // simpler syntax for iteration
            /* For every iteration tha value from the array will be copied into the "name" variable
             * and we may use it "indirectly"
             * This makes verry compact and efficient syntax when iterating
             
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            */

            // How to 
            // -iterate
            // -reverse
            string zig = "Verry long line of text bla bla bla" + 
                " and som more text in the end.";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (var zigChar in charArray)
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();

            // the use of Array will be set aside in favour for "collections"
        }
    }
}
