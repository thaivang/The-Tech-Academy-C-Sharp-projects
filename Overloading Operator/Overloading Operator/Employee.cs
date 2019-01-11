using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading_Operator
{
    class Employee
    {
        public int id;

        //public override bool Equals(object obj)
        //{
        //    Employee e = obj as Employee;
        //    if (e != null)
        //    {
        //        return e == this;
        //    }
        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    return id.GetHashCode();
        //}

        public static bool operator ==(Employee person1, Employee person2) //overloading operator name 
        {
            if (person1.id == person2.id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee person1, Employee person2)
        {
            return false;
        }
    }
}
