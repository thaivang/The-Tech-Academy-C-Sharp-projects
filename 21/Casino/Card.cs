using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card  //class is like recipe layout, object is what is being consumed
    {
        //set the value of a card so you wouldn't need to change the value of the card, structs can't be inherited
        //public Card()
        //{
        //    //These are Default values if properties are not assigned a value
        //    //constructor method are always name of the class
        //    //value assigned to object upon creation
        //    Suit = "Spades";
        //    Face = "Two";
        //}
        //One class per file, good practice
        //Card should exist independent of the game (allowing for reuse of this class)
        //Giving class a property
        //Card class has a property of data type string called Suit
        //Public - accessible by other parts of the program
        public Suit Suit { get; set; } //object Suit property get; set;
        public Face Face { get; set; }
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);//prints out 
        }
    }
        public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
