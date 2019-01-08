using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Drill pg 111
            math mathNumbers = new math(); //created a new object/instance of a class called mathNumbers
            Console.WriteLine("Passing an integer 12 and adding 10. ");
            Console.WriteLine(mathNumbers.Number(12)); //calling a method by using class, method name, parameters. Passing 12 as a parameter.
            Console.WriteLine("Passing a deciaml 5.5 and multiplying by 5. ");
            Console.WriteLine(mathNumbers.Number(5.5m)); //total is rounded to 30
            Console.WriteLine("Passing as 15 a string. ");
            Console.WriteLine(mathNumbers.Number("15")); //total is rounded to 30 
            Console.ReadLine();
        }
    }
}
