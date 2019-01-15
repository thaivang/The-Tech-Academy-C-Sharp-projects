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
            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine()); //user input
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); //lowers user answer if capitalize

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //Constructor new Player(parameters inside) + instantiate the class with constructor
                Game game = new TwentyOneGame(); //polymorphism
                game += player;
                player.IsActivelyPlaying = true; //checks if player is actively playing 
                while (player.IsActivelyPlaying && player.Balance > 0) //checks is player wants to play & balance is over 0  //video 1 & 2
                {
                    game.Play();
                }
                game -= player; //removes player when exiting game
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now."); //skips else statement if player enters no 
            Console.Read();

            // === ignore comments below ===
            //Card card = new Card();
            //card.Suit = Suit.Clubs;
            //int underlyingValue = Convert.ToInt32(Suit.Diamonds);
            //Console.WriteLine(underlyingValue);

            //== Struct ==
            //Card card1 = new Card();//instantiate a object - allocates a block of memory - assign an object from card1 to card2, object isn'y created
            //// giving card2 a memory address of card1 changing the value of card1 to card2- this is referencing an object it's (reference type)
            ////
            //Card card2 = card1;
            //card1.Face = Face.Eight; //Referring back to the card class (public struct card), card1.face is now it's own stance unrelate to card2.face
            //card2.Face = Face.King;

            //Console.WriteLine(card1.Face);
            //Object is created but not a new one 

            //== lambda ==
            //Deck deck = new Deck();

            //int count = deck.Cards.Count(x => x.Face == Face.Ace); //x represents all the elements in the list where x.Face == Face.Ace

            // --- How is this a list of 4? there are 4 kings beacuase there are 4 suits. How?
            //List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();//Takes the list of "cards" where the "x.face" == the "Face.King" and map it to a new list
            //List<int> numberList = new List<int>() { 1, 2, 3, 535, 342, 23 };

            //int sum = numberList.Sum(x => x + 5); //foreach item add 5 to it

            //Console.WriteLine(sum);

            //foreach (Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}
            //Console.WriteLine(count);

            //== /end == 

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

            //========= top of program
            //TwentyOneGame game = new TwentyOneGame(); //pertains to class game, method ListPlayers
            //game.Players = new List<string> { "Thai", "Ann", "John" };
            //game.ListPlayers();
            //Console.ReadLine();

            //21 game shuffling cards
            //Game game = new TwentyOneGame();
            //game.Players = new List<Player>(); //list needs to be instantiate before adding players to the list
            //Player player = new Player();
            //player.Name = "Thai";
            //game += player; //parameter - method in a way
            //game -= player;
        }
    }
} 
