using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an instance of a class and then call the method
            Employee person1 = new Employee();
            person1.id = 1;
            Employee person2 = new Employee();
            person2.id = 1;

            Console.WriteLine(person1.id==person2.id);
            Console.ReadLine();
        }
    }
}
