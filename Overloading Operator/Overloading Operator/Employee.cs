using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operator
{
    class Employee
    {
        public int Id { get; set; }//decalred property must be inside the class Employee

        public static bool operator ==(Employee person1, Employee person2) //overloading operator, checks if person1 id is equal to person2 id
        {
            if (person1==person2)
            {
                return true;  //1 = 2 false
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee person1, Employee person2)
        {
            if (person1!=person2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
