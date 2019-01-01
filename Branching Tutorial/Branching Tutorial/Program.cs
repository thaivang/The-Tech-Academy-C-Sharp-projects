using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            // If else branching 
            int roomTemperature = 70;
            Console.WriteLine("Hi, what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", What is the temperature where you are at?");
            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is colder than room temperature.");
            }
            else
            {
                Console.WriteLine("Something went wrong!");
            }
            Console.ReadLine();

            //example 1 Ternary statement
            Console.WriteLine("What is your favorite nnumber?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have a awesome number.";
            Console.WriteLine(result);
            Console.ReadLine();

            //example 2 Ternary Statement 
            int currentTemperature = 80;
            int roomTemperature = 70;

            // left side assign to currentTemperature : right side assign to roomTemperature
            string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "It is not room temp.";

            Console.WriteLine(comparisonResult);
            Console.ReadLine();
            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine("It is exactly room temperature.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine("It is warmer than room temperature.");
            }
            else if (roomTemperature > currentTemperature)
            {
                Console.WriteLine("Room temperature is warmer then current temperature.");
            }
            else
            {
                Console.WriteLine("It is not exactly room temperature.");
            }
            Console.ReadLine();


        }
    }
}
