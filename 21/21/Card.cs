using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Card
    {
        public Card()
        {
            //These are Default values if properties are not assigned a value
            //constructor method are always name of the class
            //value assigned to object upon creation
            Suit = "Spades";
            Face = "Two";
        }
        //One class per file, good practice
        //Card should exist independent of the game (allowing for reuse of this class)
        //Giving class a property
        //Card class has a property of data type string called Suit
        //Public - accessible by other parts of the program
        public string Suit { get; set; } //object Suit property get; set;
        public string Face { get; set; }
        //class is like recipe layout, object is what is being consumed
    }
}
