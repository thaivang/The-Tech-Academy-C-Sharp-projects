using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Prints the current date and time to the console.

            //2.Asks the user for a number.


            //3.Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

            DateTime time = DateTime.Now;             
            string format = "MMMM d yyyy hh:mm tt"; 
            Console.WriteLine("Today's date and time is: ");//formatted in -> january(MMMM), 15(d), 2019(yyyy), 6(hh):, mm(00) pm/am (tt)
            Console.WriteLine(time.ToString(format)); 
            Console.WriteLine("To find out what time it will be in the future enter a number: ");
            int hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The date and time will be: ");
            Console.WriteLine(DateTime.Now.AddHours(hour)); //finds out x amount of hours  ahead of current time
            Console.ReadLine();
        }
    }
}
