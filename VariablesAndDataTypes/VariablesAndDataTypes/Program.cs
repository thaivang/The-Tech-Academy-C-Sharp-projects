using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            //console.writeline("what is your name?");
            //string yourname = console.readline();
            //console.writeline("your name is: " + yourname);
            //console.readline();

            //How to cast
            Console.WriteLine("What is your favorite number?");
            string favoriteNumber = Console.ReadLine();
            //casting is changing a data type into another data type
            int favnum = Convert.ToInt32(favoriteNumber);
            int total = favnum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();

            //green line variable is not used yet
            //bool isStudying = false;
            //byte hoursWorked = 42;
            //sbyte currentTemperature = -23;

            //char questionMark = '\u2103';
            //Console.WriteLine(questionMark);
            //Console.ReadLine();

            //decimal moneyInBank = 100.5m;
            //double heightInCentimeters = 211.30202092;

            //float secondsLeft = 2.62f;

            //short temperatureOnMars = -341;
            //string myName = "Thai";

            //int currentAge = 23;
            //string yearsOld = currentAge.ToString();

            //bool isRaining = true;
            //string rainingStatus = Convert.ToString(isRaining);
            //Console.WriteLine(rainingStatus);
            //Console.ReadLine();


        }
    }
}
