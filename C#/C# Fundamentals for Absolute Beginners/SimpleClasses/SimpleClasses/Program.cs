using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1986;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3}", 
                myCar.Model, 
                myCar.Model, 
                myCar.Year, 
                myCar.Color);

            Console.WriteLine("Value of your car is : {0:C}", myCar.DetermineMarketValue());

            Console.ReadLine();

        }//Main

        ////method in "Program" namespace
        //private static decimal DetermineMarketValue(Car car)
        //{
        //        decimal carValue = 100.0M;
        //        return carValue;
        //}

    }//Program

    //Developer classes here
    class Car
    {
        //Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        //method in "Car" namespace
        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if (Year > 1990)
                carValue = 10000;
            else
                carValue = 2000;
            return carValue;
        }

    }


}
