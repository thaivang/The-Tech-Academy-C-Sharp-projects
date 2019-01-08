using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Drill
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Create a class called Person and give it two properties, each of data type string. One called FirstName, the other LastName.

            //2. Give this class a void method called SayName() that takes no parameters and simply writes the person's full name to the console in the format of: "Name: [full name]".

            //3. Create another class called Employee and have it inherit from the Person class. Give the Employee class a property called Id and have it be of data type int.

            //4. Inside of the Main method, instantiate and initialize an Employee object with a first name of "Sample" and a last name of "Student".

            //5. Call the superclass method SayName() on the Employee object.
            Employee person = new Employee() { FirstName = "Sample", LastName = "Student" }; //instantiate the object then initialize the object
            
            person.SayName();//call superclass method on employee object
            Console.ReadLine();
        }
    }
}
