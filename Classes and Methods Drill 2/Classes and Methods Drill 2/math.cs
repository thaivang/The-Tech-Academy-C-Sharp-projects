using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Drill_2
{
    class math
    {
        //methods with same name but must have different data types 
        public int Number (int addNumber)//create method which will be called from main program
        {
            int total1 = addNumber + 10;
            return total1;
        }
        public int Number (decimal multiplyNumber) 
        {
            int total2 = Convert.ToInt32(multiplyNumber) * 5;//converting a string value to an int
            return total2;
        }
        public int Number(string divideNumber)
        {
            int total2 = Convert.ToInt32(divideNumber) / 10;
            return total2;
        }
    }
}
