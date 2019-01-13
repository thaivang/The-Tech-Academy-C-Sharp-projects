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


        public struct Number //struct encapsulates related data types
        {
            public decimal Amount;
        }
        static void Main(string[] args)
        {
            Number price; //declare object price as Number type
            //Number newObj = new Number(); //instatiate a object
            //newObj.Amount  = 25.5m; //assign object a value 
            price.Amount = 25.5m; // specification

            Console.WriteLine(price.Amount);
            Console.ReadLine();
        }

        //struct encapsulates related variables Ex. public struct book with properties { decimal price, string title, string, author}
    }
}
