using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(); //Instantiate a object and assigned it to variable deck, empty object Deck
            deck = Shuffle(deck); //reassign values to deck from - return deck statement below method Deck shuffle on comment 2
                                  // Comment in "deck = Shuffle(deck);" to have deck in order


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }

            //deck.Cards = new List<Card>(); //instantiate with "new"
            //Card cardOne = new Card(); //oject with data type "Card" assigned to variable cardOne
            //cardOne.Face = "Queen"; //Give properties a value
            //cardOne.Suit = "Spades";
            //deck.Cards.Add(cardOne); // added one card to the deck
            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            Console.WriteLine(deck.Cards.Count); // Cards is a property of deck & a data type of list card, so list (Cards) has a property of Count
            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck ) //Method 
        {
            List<Card> TempList = new List<Card>();
            Random random = new Random();
            
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count); //get random number between 0 & 52
                TempList.Add(deck.Cards[randomIndex]); //add cards to the temporary deck
                deck.Cards.RemoveAt(randomIndex); //delete cards from the list of cards until there is no cards list

            }
            deck.Cards = TempList;
            return deck;//comment 2
        }
    }
}
