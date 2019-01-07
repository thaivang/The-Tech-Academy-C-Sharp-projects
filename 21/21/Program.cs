using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            //21 game shuffling cards
            Deck deck = new Deck(); //Instantiate a object and assigned it to variable deck, empty object Deck
            deck.Shuffle(); //calls this method and inside the parameter add a number -deck.Shuffle(3);- shuffles it 3 times
                           //calls method on itself

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            Console.WriteLine(deck.Cards.Count); // Cards is a property of deck & a data type of list card, so list (Cards) has a property of Count
            Console.ReadLine();
        }
    }
}
