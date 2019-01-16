using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_Chaining_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            const string name1  = "Peter"; 
            var firsname = new Person(name1);
            const string name2 = "Peter";
            const string name3 = "Peter Pan";
            var firstname = new Person(name2, name3); //declare const string and set new var to parameter new person(const, const)
            
            Console.ReadLine();
        }
    }
}
