using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Player
    {
        //Constructors go on top of the class
        
        public Player(string name, int beginningBalance) //constructor that takes the two parameters and assigning them to the property *1
        {
            Hand = new List<Card>(); //initialize List
            Balance = beginningBalance; //initiliaze the ojbject
            Name = name; //player name 
        }
        // Properties in the class *1
        private List<Card> _hand = new List<Card>();
        public List<Card> Hand { get { return _hand; } set { _hand = value; } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }
        public bool Stay { get; set; }


        public bool Bet(int amount)//ask for player amount
        {
            if(Balance - amount < 0)//player balance is checked 200 -210 = -10 returns false
            {
                Console.WriteLine("You do not have enough to place a bet");
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }
        public static Game operator+ (Game game, Player player) //overloading the operator, game is the return type
        {
            game.Players.Add(player);//takes game and adds player then return game - polymorphism
            return game;
        }
        public static Game operator- (Game game, Player player) //overloading operator
        {
            game.Players.Remove(player);
            return game; //player returns a game 
        }
    }
}
