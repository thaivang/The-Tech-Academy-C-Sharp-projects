using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_Lists_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex 1
            // Create a list and ask for user index input and display the value to the screen
            Console.WriteLine("=== Excercise 1 ===");
            string[] wordArray = { "apple", "oranges", "bananna", "cherry", "kiwi" };
            Console.WriteLine("Enter an index between 0 and 4 to obtain a fruit: ");
            int input = Convert.ToInt32(Console.ReadLine());


            while (input < 0 || input >= 5) //while user input value is equal to or greater than 5 it will continue to loop
            {
                Console.WriteLine("Index value is not found.");
                input = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("You picked " + wordArray[input] + ".");
            Console.ReadLine();

            //EX 2
            // Create a int array and ask user for index input and display value to the screen

            Console.WriteLine("=== Excercise 2 ===");
            int[] numArray = { 0, 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter an index between 0 and 5 to display a number.");
            int input2 = Convert.ToInt32(Console.ReadLine());


            while (input2 < 0 || input2 >= 6)
            {
                Console.WriteLine("Index value is not found.");
                input2 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your value is " + numArray[input2]);
            Console.ReadLine();

            //EX 3
            // Create a list and ask user for index input and display value to the screen

            Console.WriteLine("=== Excercise 3 ===");
            List<string> stringArray = new List<string>();
            stringArray.Add("Goodmorning");
            stringArray.Add("Goodafternoon");
            stringArray.Add("Goodnight");

            Console.WriteLine("Enter an index between 0 and 2 to display a number.");
            int input3 = Convert.ToInt32(Console.ReadLine());


            while (input3 < 0 || input3 >= 3 )
            {
                Console.WriteLine("Index value is not found.");
                input3 = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your value is " + stringArray[input3]);
            Console.ReadLine();

        }
    }
}
