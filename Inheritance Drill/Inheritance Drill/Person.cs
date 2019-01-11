using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Drill
{
    class Person
    {
        public string FirstName;// {get; set;} //property
        public string LastName;// {get; set;} //property

        public void SayName () //superclass method
        {
            Console.WriteLine("Name: [{0} {1}]", FirstName, LastName); //prints full name 
            // firstname is set to index zero, whether the initialized objects are not in order in "person" ex. LastName, Firstname
            //It will still print in order
        }
    }
}
