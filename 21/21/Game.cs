using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public abstract class Game //abstract class cannot be instantiate (object) as it can only be inherited from 
    {
        //list of player is always empty
        private List<Player> _players = new List<Player>();
        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();

        public List<Player> Players { get { return _players; } set { _players = value;  } } //property 
        public string Name { get; set; } 
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } } // dictionary with player as key and value as int
        //if getting the bets, return the private fields player, value = bets they are setting it as 

        public abstract void Play(); //abstract methods can only exist in abstract class & any class that inherit "class game" must 
                                     //implement this method ->  "public abstract void Play();"

        public virtual void ListPlayers() //virtual method in abstract class, allows you to have your own implementation of numbers of players
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }           
    }
}
