using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booleanlogic_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //And Operator
            Console.WriteLine(true && false); ////false
            Console.WriteLine(true && true); //// true
            Console.WriteLine(false && false); ////false
            Console.WriteLine(false && true); ////false

            //Or operator
            Console.WriteLine(true || true); //true
            Console.WriteLine(false || false); //false one of them is true 
            Console.WriteLine(true || false); //true 
            Console.WriteLine(false || true); //true

            //!= (does not equal to operator)
            /*Console.WriteLine(true != true);*/ ////false

            //x or operator, Branching
            Console.WriteLine(true ^ true); // ^ evaluates to true if one of them is true but not both because they are both true 
            Console.WriteLine(false ^ false); // is false because both of them is false
            Console.WriteLine(true ^ false); // true 
            Console.WriteLine(false ^ true); // true

            Console.WriteLine(true && true && true && false);


            Console.ReadLine();
        }
    }
}
