using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public class FraudException : Exception
    {
        public FraudException() //constructor
            : base() { } //base is Exception, 
        public FraudException(string message)//constructor overloading
            : base(message) { }
        //implement same Exception 
    }
}
