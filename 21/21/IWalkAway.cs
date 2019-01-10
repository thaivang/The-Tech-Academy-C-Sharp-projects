using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    interface IWalkAway
    {
        //all interface is public 
        //any class that has inheritance IWalkAway must take in the method below
        void WalkAway(Player player);
    }
}
