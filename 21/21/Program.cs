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
            TwentyOneGame game = new TwentyOneGame(); //pertains to class game, method ListPlayers
            game.Players = new List<string> { "Thai", "Ann", "John" };
            game.ListPlayers();
            Console.ReadLine();

            ////21 game shuffling cards
            //Deck deck = new Deck(); //instantiate a object and assigned it to variable deck, empty object deck
            //deck.Shuffle(3); //calls this method and inside the parameter add a number -deck.shuffle(3);- shuffles it 3 times
            //                 //calls method on itself

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count); // cards is a property of deck & a data type of list card, so list (cards) has a property of count
            //Console.ReadLine();

            //============ ignore code below 

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

            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string>() { "Thai", "Lily", "Joe" };  //access to the property and methods of the game class "game.   "
            //game.ListPlayers();
            //game.play();
            //Console.ReadLine(); //super class method which game is the super class

            //======
            //using polymorph create a list to encompass all of our games with different data types
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);

            // Game game = new TwentyOneGame();//Polymorphism, one object 21 game morph into a higher order object (inherits that object (game))
        }
    }
} 
