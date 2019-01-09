using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Dealer //Dealer is not a type of deck b/c it has a deck, 21 game class is a game - 
    {
        //turning class turn into objects
        public string Name { get; set; }//use prop then tab
        public Deck Deck { get; set; }
        public int Balance { get; set; } //track if winning or losing

        public void Deal (List<Card> Hand) //input parameter of list of card, which adds a card to the Hand
        {
            Hand.Add(Deck.Cards.First());//Hand is the list, first() takes first item in the list and add it to the hand 
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");//prints the card to the player
            Deck.Cards.RemoveAt(0); //remove the card from the deck because it is in the player's hand

            //inheritance is a not a has a relationship
            //Unsure is a or has a ? 

        }
    }
}
