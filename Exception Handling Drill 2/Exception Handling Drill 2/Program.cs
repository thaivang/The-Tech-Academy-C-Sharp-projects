using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Drill_2
{
    class Program
    {
        public class InputException : Exception //polymorphism, allows for custom name exception, constructor, allows for another constructor to inherit 
                                                //the Exception
        {
            public InputException()
                : base() { }
            public InputException(string message)//overloading constructor
                : base(message) { }
        }

        static void Main(string[] args)
        {
            //1.Ask the user for his age.

            //2.Display the year user born.

            //3.Exceptions must be handled using "try .. catch".

            //4.Display appropriate error messages if user enters zero or negative numbers.

            //5.Display a general message if exception caused by anything else.

            int age; //default value
            try
            {
                //bool validAnswer = false;
                //while (!validAnswer) //keep looping until valid answer is input, false
                //{
                //    Console.WriteLine("What is your age?");
                //    validAnswer = int.TryParse(Console.ReadLine(), out age); //return a bool value, trys to convert returns result
                //    if (!validAnswer) Console.WriteLine("Please enter only digits.");
                //}

                Console.WriteLine("What is your age?");
                age = int.Parse(Console.ReadLine());
                if (age < 1)
                {
                    throw new InputException();
                }
                var today = DateTime.Now;

                // Calculate the age.
                var year1 = today.Year - 1 - age;//subtracts today's year minus 1 because subtracting from 2019 then user's age 
                //without subtrating 1, the starting date would be 2019 which would imply user is born a year ahead of orginal birthday EX. 23 years old = 1994 (wrong result)
                var year2 = today.Year - age;
                Console.WriteLine("You were born in " + year1+ " otherwise if you had a birthday this year you would be born on " + year2);
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter only an integer");
            }
            catch(InputException)
            {
                Console.WriteLine("Error! You enter zero or a negative number. Enter a number greater than 0.");
            }
            catch (Exception) //general exceptions
            {
                Console.WriteLine("An Error occured. Please contact support.");
                Console.ReadLine();
                return;//end program with return
            }
            Console.ReadLine();
        }
    }
}
