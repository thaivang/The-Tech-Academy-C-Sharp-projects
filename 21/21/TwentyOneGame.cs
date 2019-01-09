using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class TwentyOneGame : Game
    {
        //Inheritance class
        //use colon : in class name, TwentyOneGame now inherits the class Game
        public override void Play() //use override in method when inheriting abstract class
        {
            throw new NotImplementedException(); //throws an error when attempting to run it. Need to define the method
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }
    }
}
