using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Parameters_Drill
{
    public class Optional_Parameters
    {
        public static int twoParameters (int first, int second = 0) //optional 2nd parameter, set to 0 if user enters only one input
        {
            int total = first + second;
            return total;
        }
    }
}
