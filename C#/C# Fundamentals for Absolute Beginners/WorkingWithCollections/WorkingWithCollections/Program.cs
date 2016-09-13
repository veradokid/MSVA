using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            //Instatiate and populate with values
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";
            car1.VIN = "A1";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";
            car2.VIN = "A2";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .NET XML Web Services";
            b1.ISBN = "0-000-00000-0";
            */


            /*
            // Arraylists are "old style"
            // ArrayLists are dynamically sized
            // Cool features

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);

            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }
            */

            /*
            //List<T>   
            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            //myList.Add(b1);   Will not even compile

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }
            */

            /*
            //Dictionary
            //Two components. The keyword and the description; the Key and the Value, with corresponding types: TKey, TValue

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);

            Console.WriteLine(myDictionary["A2"].Make);     //Lookup and use the value directly
            */


            // Example of verry effective and dense syntax:

            // Array initializer syntax
            // init an array with values by assigning a collection to it
            string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            // Object intializer syntax
            // No need for Contstructor
            // init an instance with values by assigning a collection to it
            Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "C3" };
            Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "B4" };

            // Collection initializer
            //1.Creating new list
            //2.insert new elements in list by assigning a collection to it.
            //(new elements are returned by the Car constructor)
            //(the new car instances are already initialized by assigning a collection to it)
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "E5" },
                new Car { Make = "Nissan", Model = "Altina", VIN = "F6" }
            };

            Console.ReadLine();

        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
