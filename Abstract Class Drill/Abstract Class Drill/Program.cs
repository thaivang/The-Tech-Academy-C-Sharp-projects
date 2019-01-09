using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Drill
{
    class Program
    {
        public abstract class Person //abstract class 
        {
            public string FirstName;
            public string LastName;
            public abstract void SayName();
        }


        public class Employees : Person //inheritance class
        {
            public override void SayName() //must implement the abstract method using override
            {
                Console.WriteLine(FirstName + " " + LastName); //prints to console
            }
        }

        static void Main(string[] args)
        {
            Employees name = new Employees() { FirstName = "Sample", LastName = "Student" }; //instantiate the object and initialize it
            name.SayName(); //call the sayName method
            Console.ReadLine();
        }
    }
}
