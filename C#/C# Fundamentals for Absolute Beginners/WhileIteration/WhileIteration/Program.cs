using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }

        //developer methods here
        private static bool MainMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Option 1");
            Console.WriteLine("2. Option 2");
            Console.WriteLine("3. Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GuessingGame();
                return true;
            }
            else if (result == "3")
            {
                return false;
            }
            else
            {
                return true;
            }
        }//MainMenu

        private static void PrintNumbers()
        {
            Console.WriteLine("Print numbers");
            Console.Write("Type a number: ");
            int result = int.Parse(Console.ReadLine());
            int counter = 1;
            while (counter < result + 1)
            {
                Console.Write(counter);
                if (counter < result)
                    Console.Write("-");
                counter++;
            }
            Console.ReadLine();
        }//PrintNumbers

        private static void GuessingGame()
        {
            Console.WriteLine("Guessing game");
            Console.ReadLine();
        }//GuessingGame
    }
}
