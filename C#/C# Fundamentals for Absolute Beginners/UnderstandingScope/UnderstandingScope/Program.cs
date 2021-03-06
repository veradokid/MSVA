﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        private static string k = "";

        static void Main(string[] args)
        {

            string j = "";  //j is defined outside the for loop. available both places.

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }
                //Console.WriteLine(l);   //not in scope
            }
            //Console.WriteLine(i);   //will not compile: i out of scope

            Console.WriteLine("Outside of the scope, j = " + j);
            Console.WriteLine("Outside of the for-loop, k = " + k);
            HelperMethod();

            Car myCar = new Car();
            myCar.DoSomething();    //the only member visible from the outside

            Console.ReadLine();
        }//main

        static void HelperMethod()
        {
            Console.WriteLine("Value k from the HelperMethod():" + k);
        }

        class Car
        {
            public void DoSomething()
            {
                Console.WriteLine(HelperMethod());
            }

            private string HelperMethod()
            {
                return "Hello World";
            }
        }




    }
}
