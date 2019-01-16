using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Casino
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
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);//prints the card to the player // - Deck.Cards.First().ToString() + "\n"
            //Deck.Cards.RemoveAt(0); //remove the card from the deck because it is in the player's hand
            using (StreamWriter file = new StreamWriter("C:\\log.txt", true)) //dispose of memory when done using, that's what the using statement is
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);
   
            //inheritance is a not a has a relationship
            //Unsure is a or has a ? 
        }
    }
}
