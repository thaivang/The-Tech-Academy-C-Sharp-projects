using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            // looping until input is correct but does not diaplay message which is fixed using do while loop
            while (!isGuessed) //(!isGuessed) is equal to (isGuessed == false)
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct.");
                        isGuessed = true;
                        break;
                    default: // If none of the cases are met default will run
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
                Console.ReadLine();
            }

            //switch statement
            switch (number)
            {
                case 62:
                    Console.WriteLine("You guessed 62. Try again.");
                    break;
                case 29:
                    Console.WriteLine("You guessed 29. Try again.");
                    break;
                case 55:
                    Console.WriteLine("You guessed 55. Try again.");
                    break;
                case 12:
                    Console.WriteLine("You guessed the number 12. That is correct.");
                    break;
                default: // If none of the cases are met default will run
                    Console.WriteLine("You are wrong.");
                    break;
            }
            Console.ReadLine();


            //do while loop 
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct.");
                        isGuessed = true;
                        break;
                    default: // If none of the cases are met default will run
                        Console.WriteLine("You are wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            // looping until input is correct
            while (!isGuessed); //(!isGuessed) is equal to (isGuessed == false)

            Console.Read();
        }
    }
}
