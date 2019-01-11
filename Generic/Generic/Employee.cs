using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Generic
{
    class Employee<T>
    {
        public List<T> Things {get;set;} //property be a generic list called things    
    }
}
