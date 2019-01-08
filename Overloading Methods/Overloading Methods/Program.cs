using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Methods
{
    class Program
    {
         static void Main(string[] args)
        {
            //1.Create a class. In that class, create a void method that outputs an integer.Have the method divide the data passed to it by 2.

            //2. In the Main() method, instantiate that class.

            //3. Have the user enter a number.Call the method on that number.Display the output to the screen. It should be the entered number, divided by two.

            //4. Create a method with output parameters.

            //5. Overload a method.

            //6. Declare a class to be static.

            overloading_methods favoriteNumber = new overloading_methods(); //object  allows access to nonstatic methods
            Console.WriteLine("What is your favorite number?");
            
            try
            {
                int userInput = Convert.ToInt32(Console.ReadLine()); //takes input from user
                favoriteNumber.divide(userInput); //calls first method by taking user input and divides it by 2 
                overloading_methods.divide(userInput, out userInput); //calls second method and outputs user input / 2
                //user input parameter 1 and user input parameter 2
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only an integer.");
            }
            Console.ReadLine();
        }      
    }
}
 