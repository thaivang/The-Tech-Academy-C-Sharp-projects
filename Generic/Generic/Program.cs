using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics

            //1.Make the Employee class take a generic type parameter.

            //2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.

            //3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.

            //4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.

            //5. Create a loop that prints all of the Things to the Console.

            Employee<string> employee = new Employee<string>(); //Instatitate employee object type string with generic parameter
            Employee<int> employeeId = new Employee<int>();
            employee.Things = new List<string>(); //object (string) . things (property) = new list, creating string object employee from list things to new list
            employeeId.Things = new List<int>(); //assigns a list as property values of Things

            employee.Things.Add("Billy");//add to list of strings
            employee.Things.Add("Bob");
            employee.Things.Add("JOE");
            employeeId.Things.Add(1); //add to list of ints
            employeeId.Things.Add(2);
            employeeId.Things.Add(3);

            foreach (string name in employee.Things) //each name in 
            {
                Console.WriteLine(name);
            }
            foreach (int Id in employeeId.Things)
            {
                Console.WriteLine(Id);
            }
            Console.ReadLine();
        }
    }
}
