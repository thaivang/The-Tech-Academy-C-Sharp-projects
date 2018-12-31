using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person 1
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1: ");
            Console.WriteLine("What is person1's Hourly Rate?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("How many hours does Person1 work per week?");
            int userInput2 = Convert.ToInt32(Console.ReadLine());

            //Person 2
            Console.WriteLine("Person 2: ");
            Console.WriteLine("What is person's 2 hourly Rate");
            int userInput3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many hours does person2 work per week?");
            int userInput4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The annual salary of Person 1 is:");
            int income1 = userInput * userInput2 * 52;
            Console.WriteLine(income1);
            Console.WriteLine("The annual salary of Person 2 is:");
            int income2 = userInput3 * userInput4 * 52;
            Console.WriteLine(income2);

            //Boolean check
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1 = income1;
            int person2 = income2; 
            bool value = person1 > person2;
            Console.WriteLine(value);
            Console.ReadLine();

        }
    }
}
