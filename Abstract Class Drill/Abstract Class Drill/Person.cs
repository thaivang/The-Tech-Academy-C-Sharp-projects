using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Drill
{
    public abstract class Person //abstract class are incomplete classes 
    {
        public string FirstName; //property
        public string LastName; //property
        public abstract void SayName();//abstract method with no curly braces, no implementation, provides any class derive from it to implement it
    }

    public class Employees : Person , IQuittable //inheritance class
    {
        public void Quit()
        {
            Console.WriteLine("Goodbye");
        }
        public override void SayName() //must implement the abstract method using override
        {
            Console.WriteLine(FirstName + " " + LastName); //prints to console
        }
    }

    //interface can only have a declaration like property and not an implementation
    //all methods in interface are abstract
    //can't instantiate, implemented by a class must take methods in interface, gets around multiple inheritance
}
