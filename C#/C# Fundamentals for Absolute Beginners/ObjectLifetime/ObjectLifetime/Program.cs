using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            //myCar.Make = "Oldsmobile";
            //myCar.Model = "Cutlas Supreme";
            //myCar.Year = 1986;
            //myCar.Color = "Silver";


            Car myOtherCar;         //constructor is run anyways!? -prob not
            myOtherCar = myCar;     //Two references to the same instance

            Console.WriteLine("{0} {1} {2} {3}",
                myOtherCar.Make,
                myOtherCar.Model,
                myOtherCar.Year,
                myOtherCar.Color);

            myOtherCar.Model = "98";

            Console.WriteLine("{0} {1} {2} {3}",
                myCar.Make,
                myCar.Model,
                myCar.Year,
                myCar.Color);

            //myOtherCar = null;  //terminating the reference
            ///*
            // * However you will not be absolutly sure WHEN .NET garbage collection will remove instance from memory
            // * */

            //Console.WriteLine("{0} {1} {2} {3}",
            //    myOtherCar.Make,
            //    myOtherCar.Model,
            //    myOtherCar.Year,
            //    myOtherCar.Color);


            Car myThirdCar = new Car("Ford", "Escape", 2005, "Yellow");
            Console.WriteLine("{0} {1} {2} {3}",
                myThirdCar.Make,
                myThirdCar.Model,
                myThirdCar.Year,
                myThirdCar.Color);

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()    //constructor method is called the same as the class
        {
            // You could load default sttings from config file or db
            Make = "Nissan";
        }

        public Car(string make, string model, int year, string color)    //overloaded constructor
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
    }

}
