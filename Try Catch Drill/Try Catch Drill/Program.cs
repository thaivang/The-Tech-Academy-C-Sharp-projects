using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers. Ask the user for a number to divide each number in the list by. 
            //Write a loop that takes each integer in the list, divides it by the number the user entered, 
            //and displays the result to the screen.

            List<int> integers = new List<int>() {1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine("Enter a number: ");
                int userInput = Convert.ToInt32(Console.ReadLine());
                foreach (int i in integers)
                {
                    int total = (i / userInput);
                    Console.WriteLine("Dividing " + i + " by " + userInput + " is " + total);
                }
            }
            catch (FormatException) 
            {
                Console.WriteLine("Please enter only a whole number.");
                return;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            finally //Prevent console from closing immediately
            {
                Console.WriteLine("The program has successfully executed. End of program.");
                Console.ReadLine();
            }

            //========================
            //Another loop that asks a user to enter a number 5 times while iterating through each number in the list.
            //EX. 5/1, 5/2, 5/3, ect. 
            //try
            //{
            //    for (int i = 0; i < integers.Count; i++)
            //    {
            //        Console.WriteLine("Enter a number: ");
            //        int userInput = Convert.ToInt32(Console.ReadLine());
            //        int total = userInput / integers[i];
            //        Console.WriteLine("Dividing " + userInput + "by" + integers[i] + "is" + total);
            //    }
            //    Console.ReadLine();
            //}
            // Foreach loop one input for all items in list ex. 5 items
            // for loop multiple inputs iterating through a set list ex. 5 items
        }
    }
}
