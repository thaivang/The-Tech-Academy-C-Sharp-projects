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
            Console.WriteLine("Anonymouse Income Comparison Program");
            Console.WriteLine("Person 1: ");
            Console.WriteLine("Hourly Rate?");
            Console.WriteLine("15");
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");

            //Person 2
            Console.WriteLine("Person 2: ");
            Console.WriteLine("Hourly Rate");
            Console.WriteLine("20");
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("40");

            Console.WriteLine("Weekly salary of Person 1:");
            Console.WriteLine("600");
            Console.WriteLine("Weekly salary of Person 2:");
            Console.WriteLine("800");

            //Boolean check
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int person1 = 600;
            int person2 = 800;
            bool value = person1 > person2;
            Console.WriteLine(value);
            Console.ReadLine();

        }
    }
}
