using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========== Excercise 1");
            // One dimensional array
            // Create loop that adds each user text to the string 

            string[] listwords = new string[4];

            for (int i = 0; i < 4; i++) //for each text enter, it will increment by 1, adding to listwords 
            {
                Console.WriteLine("enter a text of your choosing.");

                listwords[i] = Console.ReadLine();
            }
            Console.WriteLine("here are the texts you enter: ");

            foreach (string i in listwords)
            {

                Console.WriteLine(i);
            }

            Console.WriteLine("========== Excercise 2 == Comment out this to enable the infinite loop");
            //Infinite Loop 
            //Comment out to initiate a loop

            //for (int i = 0; i >= 0; i++)
            //{
            //    Console.WriteLine("infinite loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 
            //}


            Console.WriteLine("========== Excercise 3");
            //Fix infinite loop to execute
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Fix loop " + i); // as long as " i " the condition, is greater than 0 it will increment by 1 until 5
            }

            Console.WriteLine("========== Excercise 4");
            //Continue to iterate until a < operator is reached. Stops at int 4
            int j = 0;
            while (j < 5)
            {
                Console.WriteLine("The program has reached the < operator " + j);
                j++;
            }

            Console.WriteLine("========== Excercise 5");
            //Continue to iterate until a < operator is reached. Stops at int 5
            int x = 0;
            while (x <= 5)
            {
                Console.WriteLine("The program has reached the <= operator " + x);
                x++;
            }

            Console.WriteLine("========== Excercise 6 with 7 & 8");
            //Create list of string where user select text to search and displays matching index to the screen
            // everything in .net is an object
            List<string> sweets = new List<string>() { "crunch", "skittles", "butterfingers", "oreo", "starburst" };
            Console.WriteLine("Enter a word to search.");
            string input = Console.ReadLine();
            bool records = false;

            foreach (string i in sweets)
            {

                if (input == i)
                {
                    Console.WriteLine("You got an index of: " + sweets.IndexOf(i));
                    records = true;
                    break; //stops code from executing once match is found (implemented "break" for EX. 8 even though "true" will stop the code from running when correct value is entered.)
                }
            }
            if (!records) //if text doesn't exist this wil print to screen EX. 7
            {
                Console.WriteLine("Your text doesn't exist in the list sweets.");
            }

            Console.WriteLine("========== Excercise 9 & 10");
            //Create a List of strings that has at least two identical strings in the List. 
            //Ask the user to select text to search for in the List.
            //Create a loop that iterates through the list and then displays the indices of the array that contain matching text on the screen.

            List<string> sweets1 = new List<string>() { "crunch", "crunch", "skittles", "skittles", "butterfingers", "butterfingers", "oreo", "oreo", "starburst", "starburst" };
            Console.WriteLine("Enter a word to search.");
            string input1 = Console.ReadLine();
            bool records1 = false;

            for (int k = 0; k < 10; k++)
            {
                if (sweets1[k] == input1)
                {
                    Console.WriteLine("Your item has an index of: " + k);
                    records1 = true;
                    //stops code from executing once match is found
                }
            }
            if (!records1) //if text doesn't exist this wil print to screen ex. 10
            {
                Console.WriteLine("Your text doesn't exist in the list sweets.");
            }


            Console.WriteLine("========== Excercise 11");
            // Checks if item is already in the list then displays the string and wether or not it has appeared in the list.

            foreach (string y in sweets1)
            {
                Console.WriteLine("This item already appears in the list: ");
                {
                    Console.WriteLine(y);
                }
            }
            Console.ReadLine();
        }
    }
}
