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
            try
            {
                string content = File.ReadAllText(@"c:\Lesson22\Exampl.txt");
                Console.WriteLine(content);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("FileNotFound!");
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("DirectoryNotFound!");
            }
            catch (Exception ex)
            {
                //throw;
                Console.WriteLine("There was a problem!");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Code to finalize
                // Setting objects to null
                // Closing database connection
                Console.WriteLine("Closing the app now!");
            }
            Console.ReadLine();
        }
    }
}
