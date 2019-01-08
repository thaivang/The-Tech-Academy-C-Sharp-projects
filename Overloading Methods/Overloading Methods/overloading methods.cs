using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Methods
{
    public class overloading_methods
    {
        public void divide (int inNumber) // input of user number
        {
            int total =  inNumber / 2;
            Console.WriteLine(total); //outputs user input /2 to console
        }
        public static void divide (int inNumber1, out int outNumber2) //output of user number, overloading method
        {                                                           //use out parameter to output user input / 2 to screen
            int total = outNumber2 = inNumber1 /2 ;
            //Console.WriteLine(total);
        }
        public static class empty //declare a static class
        {

        }
    }
}
