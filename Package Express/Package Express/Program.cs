using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Enter your package weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight <= 50)
            {
                Console.WriteLine("Proceed to enter your dimensions.");
            }
            else
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Height: ");
            int height = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Width: ");
            int Width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimensions = height + Width + length;

            if (dimensions > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                int total = dimensions * weight / 100;
                Console.WriteLine("Your total is: $" + total);
            }
            
            Console.ReadLine();
        }
    }
}
