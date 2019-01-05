using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exception Handling with try catch block 

            try
            {
                Console.WriteLine("Pick a number.");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick a second number.");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("divinding the two...");
                int numberThree = numberOne / numberTwo;
                Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
                Console.ReadLine();
            }
            catch (FormatException ex) //Assigning to varibale ex which is a data type format exception
            {
                //Console.WriteLine(ex.Message);
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex) //General exeption
            {
                Console.WriteLine(ex.Message);
            }
            finally //Prevent console from closing immediately
            {
                Console.ReadLine();
            }
            
        }
    }
}
