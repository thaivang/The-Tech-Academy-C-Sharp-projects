using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Optional_Parameters storNumbers = new Optional_Parameters(); //Instantiate the class object
            Console.WriteLine("Enter a number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a second number (optional):  or press ENTER to skip and see your total.\n");

            int total; //declare in main in order for "total" to be recognized in context. 
            var validInput = int.TryParse(Console.ReadLine(), out int input2); //represents a boolean value 

            
            if (validInput)
            {
                total = Optional_Parameters.twoParameters(input1,input2);
            }
            else
            {
                total = Optional_Parameters.twoParameters(input1);
            }

            Console.WriteLine("Your total is: "+ total);
            Console.ReadLine();
        }
    }
}
