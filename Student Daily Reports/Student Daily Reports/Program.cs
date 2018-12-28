using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Daily_Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseNumber = Console.ReadLine();

            Console.WriteLine("What page number are you currently on?");
            int pageNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Do you need help with anything? Please answer true or false.");
            bool input = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific?");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
