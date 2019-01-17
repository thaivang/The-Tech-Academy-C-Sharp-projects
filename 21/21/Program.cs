using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;
using System.Data.SqlClient;
using System.Data;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            const string casinoName = "Grand Hotel and Casino";

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name.", casinoName);
            string playerName = Console.ReadLine(); 
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.WriteLine(exception.ExceptionMessage + " | ");
                    Console.WriteLine(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }
            bool validAnswer = false;
            int bank = 0;
            while (!validAnswer)
            {
                Console.WriteLine("And how much did you bring today?");
                validAnswer = int.TryParse(Console.ReadLine(), out bank);//assign a value and send back out result, cast from string to int using tryparse
                //if cast doesn't succeed then it prints out zero becuase int bank = 0;
                if (!validAnswer) Console.WriteLine("Please enter only digits only, no decimals.");
            }

            
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower(); //lowers user answer if capitalize

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank); //Constructor new Player(parameters inside) + instantiate the class with constructor
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter("C:\\log.txt", true)) //dispose of memory when done using, that's what the using statement is
                {
                    file.WriteLine(player.Id);
                }
                //GUID
                Game game = new TwentyOneGame(); //polymorphism
                game += player;
                player.IsActivelyPlaying = true; //checks if player is actively playing 
                while (player.IsActivelyPlaying && player.Balance > 0) //checks is player wants to play & balance is over 0  //video 1 & 2
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)//specific exception then general exception, program runs in order from 1st catch
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);//exception object, updates db with error, knows when person is kicked 
                        Console.ReadLine();
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occured. Please contact your system administrator.");
                        UpdateDbWithException(ex);
                        Console.ReadLine();
                        return; //ends the program using return in void method
                    }
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
        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp) VALUES 
                                    (@ExceptionType, @ExceptionMessage, @TimeStamp)"; //map exact values, protect against SQl injection using parameterize queries

            using (SqlConnection connection = new SqlConnection(connectionString)) //"Using" keyword helps controlling unmanaged code / external resources, allows you to close the connection
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);//data type is SqlDbTyp.VarChar, by naming the data type you are protecting against SQL Injection
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);//parameters with data type
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();//open connection to database
                command.ExecuteNonQuery();//insert statement because it's a nonquery
                connection.Close();
            }
        }
        private static List<ExceptionEntity> ReadExceptions()//queries all database and displays all exceptions
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TwentyOneGame;
                                        Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;
                                        ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string queryString = @"Select Id, ExceptionType, ExceptionMessage, TimeStamp From Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())//loops through each record and creates new exception entity object
                {
                    ExceptionEntity exception = new ExceptionEntity();//mapping back to the object
                    exception.Id = Convert.ToInt32(reader["Id"]);//map back to object, converts SQL back to data type C#
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);//adds to list 
                }
                connection.Close();
            }
            //ADO .Net
            return Exceptions;
        }
    }
} 
