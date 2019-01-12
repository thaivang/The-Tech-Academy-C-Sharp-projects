using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create an enum for the days of the week.

            //2. Prompt the user to enter the current day of the week.

            //3. Assign the value to a variable of that enum data type you just created.

            //4. Wrap the above statement in a try/catch block and have it print "Please enter an actual day of the week." to the console if an error occurs.


            
            
                try
                {
                    Console.WriteLine("What day is it today?");
                    string today = Console.ReadLine().ToLower(); //If user enters capital case of any days it will be lower
                    Day inputDay = (Day)Enum.Parse(typeof(Day),today);
                    //Day days; //assign variable to enum type of day
                    //today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek.), inputDay);
                    if (Enum.TryParse(today, out Day dayResult))
                    {
                        Console.WriteLine("Today's day is " + dayResult);  
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Please enter an actual day of the week.");
                }
                Console.ReadLine();

            //================================
            //      ENUM TryParse()
            //===============================

            //Console.WriteLine("What day is it today?");
            //string today = Console.ReadLine().ToLower(); //If user enters capital case of any days it will be lower
            //                                             //Day days; //assign variable to enum type of day
            //                                             //today = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek.), inputDay);
            //if (Enum.TryParse(today, out Day dayResult))
            //{
            //    Console.WriteLine("Today's day is " + dayResult);
            //}

            //================================
            //      ENUM TryParse() II
            //===============================


            //Console.WriteLine("Pick a day of the week (case-insensitive string or number from 0 to 6, 0 being Sunday)");
            //string input = Console.ReadLine();

            //if (Enum.IsDefined(typeof(DaysOfTheWeek), input.ToUpper()) || Enum.IsDefined(typeof(DaysOfTheWeek), Convert.ToInt32(input)))
            //{
            //    Console.WriteLine("It's in the enum!");
            //}
            //else
            //{
            //    Console.WriteLine("Please enter an actual day of the week");
            //}
        }
    }
}
