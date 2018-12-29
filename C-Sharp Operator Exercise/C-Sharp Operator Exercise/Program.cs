using System;

namespace C_Sharp_Operator_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Take user input and multiply by 50
            Console.WriteLine("Please enter a number that will be multiply by 50: ");
            try
            {
                ulong userNumber1 = Convert.ToUInt64(Console.ReadLine());
                Console.WriteLine("Your number multiply by 50 is: " + userNumber1 * 50);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only a number!");
            }
            Console.ReadLine();

            //Take user input and add 25
            Console.WriteLine("please enter a number that will add 25 to it: ");
            try
            {
                int usernumber2 = Convert.ToInt32(Console.ReadLine());
                int newnumber1 = (usernumber2 + 25);
                Console.WriteLine("your number added by 25 is: " + newnumber1);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only a number!");
            }
            Console.ReadLine();

            //takes user input and divides by 12.5
            Console.WriteLine("please enter a number that divides by 12.5: ");
            try
            {
                double usernumber3 = double.Parse(Console.ReadLine());
                double newnumber2 = (usernumber3 / 12.5);
                Console.WriteLine("your number divided by 12.5 is: " + newnumber2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only a number!");
            }
            Console.ReadLine();

            //takes user input and checks if it is greater than 50 then prints true/false
            Console.WriteLine("please enter a number that will check if it is greater than 50: ");
            try
            {
                int usernumber4 = Convert.ToInt32(Console.ReadLine());
                int setvalue = 50;
                bool value = usernumber4 > setvalue;
                Console.WriteLine(value);
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter only a number!");
            }
            Console.ReadLine();

            //takes user input and divides by 7 and prints the remainder
            Console.WriteLine("please enter a number that will divide by 7 and return a remainder: ");
            try
            {
                int usernumber5 = Convert.ToInt32(Console.ReadLine());
                int newnumber3 = usernumber5 % 7;
                Console.WriteLine("your number divided by 7 gives a remainder of: " + newnumber3);
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter only a number!");
            }
            Console.ReadLine();
            Console.WriteLine("End of Program, press enter to exit.");
            Console.ReadLine();
        }
    }
}
