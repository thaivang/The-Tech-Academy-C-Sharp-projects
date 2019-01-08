using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_methods_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class. In that class, create three methods, each of which will take one integer parameter in and return an integer.
            //The methods should do some math operation on the received parameter.Put this class in a separate.cs file in the application.

            //2. In the Main() program, ask the user what number they want to do the math operations on.

            //3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.
            methods math = new methods();
            Console.WriteLine("Please enter a number into the math operations machine: "); 
            int input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your number enter plus 10 = " + math.mathOperation1(input) ); //calls the method and passes the
            Console.WriteLine("Your number enter subtract 10 = " + math.mathOperation2(input)); // user input as a parameter
            Console.WriteLine("Your number enter times 10 = " + math.mathOperation3(input));
            Console.ReadLine();
        }
    }
}
