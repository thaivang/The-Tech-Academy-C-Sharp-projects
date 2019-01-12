using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    class Program
    {
        //1. Create a struct called Number and give it the property "Amount" and have it be of data type decimal.

        //2. In the Main() method, create an object of data type Number and assign an amount to it.

        //3. Print this amount to the console.


        public struct Number //Create struct
        {
            public decimal Amount { get; set; }
        }
        static void Main(string[] args)
        {
            Number newObj = new Number(); //instatiate a object
            newObj.Amount  = 25.5m; //assign object a  
            Console.WriteLine(newObj.Amount);
            Console.ReadLine();
        }
    }
}
