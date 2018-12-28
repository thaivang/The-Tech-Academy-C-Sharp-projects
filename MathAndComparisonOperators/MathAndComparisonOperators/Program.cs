using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            //Console.writeline("five plus ten = " + total); //demonstrating a cast from int to string
            int othertotal = 12 + 32;
            int combined = total + othertotal;
            Console.WriteLine(combined);
            Console.WriteLine();

            int difference = 10 - 5;
            Console.WriteLine("ten minus five = " + difference.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine(product);
            Console.ReadLine();

            int quotient = 100 / 5;
            Console.WriteLine(quotient);
            Console.ReadLine();

            double quotient1 = 100.0 / 17.0;
            Console.WriteLine(quotient1);
            Console.ReadLine();

            int quotient2 = 100 / 17;
            Console.WriteLine(quotient2);
            Console.ReadLine();

            int remainder = 10 % 2; //even
            Console.WriteLine(remainder);
            Console.ReadLine();

            //------Comaprison operators------

            bool trueorfalse = 12 > 5;
            Console.Write(trueorfalse.ToString());
            Console.ReadLine();

            //---Using bool operator to test for values >=, <=, !=, ==
            int roomTemperature = 70;
            int currentTemperature = 70;
            bool isWarm = currentTemperature >= roomTemperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
}
