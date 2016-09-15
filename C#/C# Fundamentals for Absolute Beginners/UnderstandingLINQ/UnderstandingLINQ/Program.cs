using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>() {
                new Car() { VIN="A1", Make = "BMW", Model= "550i", StickerPrice=55000, Year=2009},
                new Car() { VIN="B2", Make="Toyota", Model="4Runner", StickerPrice=35000, Year=2010},
                new Car() { VIN="C3", Make="BMW", Model = "745li", StickerPrice=75000, Year=2008},
                new Car() { VIN="D4", Make="Ford", Model="Escape", StickerPrice=25000, Year=2008},
                new Car() { VIN="E5", Make="BMW", Model="55i", StickerPrice=57000, Year=2010}
            };

            // LINQ query syntax
            /* ex.1 Filter
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2010
                       select car;
            */

            /* ex.2 Order
            var orderedCars = from car in myCars
                              orderby car.Year descending
                              select car;
            */

            // LINQ method syntax            
            // ex.1 Filter
            //var bmws = myCars.Where(p => p.Make == "BMW" && p.Year == 2010);

            // ex.2 Order
            //var orderedCars = myCars.OrderByDescending(c => c.Year);

            // ex.3 Find first item
            //var firstCar = myCars.OrderByDescending(c => c.Year).First(c => c.Make == "BMW");
            //Console.WriteLine("{0} {1} {2}", firstCar.Model, firstCar.VIN, firstCar.Year);

            // ex.4 
            //Console.WriteLine(myCars.TrueForAll(p=>p.Year > 2010));

            // ex.5
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            // ex.6
            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            // ex.7
            // Console.WriteLine(myCars.Exists(p => p.Model == "745li"));

            // ex.8
            Console.WriteLine(myCars.Sum(p => p.StickerPrice));

            /*
            foreach (var car in orderedCars)
            {
                Console.WriteLine("{0} {1} {2}" ,car.Model, car.VIN, car.Year);
            }
            */

            Console.ReadLine();

        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
