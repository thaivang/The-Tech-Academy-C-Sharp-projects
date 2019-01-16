using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_and_Chaining_Constructors
{
    class Person
    {
        string person;
        public Person(string name1) : this(name1, "")//constructor chaining, reusing the previous constructor specifiying using "this" keyword
                                                    //otherwise we would be calling the constructor class (base class)
        {

        }
        public Person(string name1, string name2)
        {
            person = name1;
            person = name1 + " " + name2;
            Console.WriteLine("I'M " + person);
            Console.WriteLine("NO, I'M " + person + " !");
        }
    }
}
