using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Drill
{
    class Method //instantiate object of a class called Method
    {
        public static int Addition(int num) //Name of method, passes parameter int num
        {
            int total = 20 + num;
            return total;
        }
        public static int Subtraction(int num)
        {
            int total = 20 - num;
            return total;
        }
        public static int Divide(int num)
        {
            int total = 20 / num;
            return total;
        }
    }
}
