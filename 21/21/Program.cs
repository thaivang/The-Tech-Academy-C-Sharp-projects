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
            // 1 way of creating values
            //Card card = new Card();
            //card.Face = "King";
            //card.Suit = "Suit";

            //2 way of creating values
            //Object initialization
            //Card card = new Card();
            //{ Face = "King", Suit = "Spades"}; //Initializes the object with values

            //Game games = new Game();
            //game.Dealer = "Thai";
            //game.Name = "TwentyOne";

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Thai", "Lily", "Joe" };  //access to the property and methods of the game class "game.   "
            game.ListPlayers();
            game.play();
            Console.ReadLine(); //super class method which game is the super class

            //21 game shuffling cards
            Deck deck = new Deck(); //Instantiate a object and assigned it to variable deck, empty object Deck
            deck.Shuffle(3); //calls this method and inside the parameter add a number -deck.Shuffle(3);- shuffles it 3 times
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
