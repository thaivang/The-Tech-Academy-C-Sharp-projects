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


            Employee person1 = new Employee //create an instance of a class and then call the method
            {
                Id = 1 //object.property
            };  

            Employee person2 = new Employee
            {
                Id = 2
            };

            //Console.WriteLine(person1!=person2);
            Console.WriteLine(person1==person2); //prints out result 
            Console.ReadLine();
        }
    }
}
