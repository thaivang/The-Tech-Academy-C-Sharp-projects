using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceQualification
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? Enter a true or false.");
            bool DUI = Convert.ToBoolean(Console.ReadLine());           
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTicket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified?");
            if (userAge >15 && DUI == false && speedingTicket <= 3)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();

        }
    }
}
