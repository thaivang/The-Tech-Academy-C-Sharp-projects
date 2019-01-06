using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Drill
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a  number: ");

            try
            {
                int numInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(Method.Addition(numInput)); //Calling a method on an object
                Console.WriteLine(Method.Subtraction(numInput)); //After the object name, add a period, the name of the method, and parentheses with parameters.
                Console.WriteLine(Method.Divide(numInput)); // 
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only a number.");
            }
            finally
            {
                Console.WriteLine("This is the end of the program. Thankyou!");
                Console.ReadLine();
            }
            
        }
    }
}
