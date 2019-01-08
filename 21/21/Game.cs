using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class Game
    {
        //Design towards abstraction - tip
        //Instead of creating a name like 21Game then it will be only tied to one game
        //but a generic name like "Game" you can use for future projects
        public List<string> Players { get; set; } //property 
        public string Name { get; set; } 
        public string Dealer { get; set; } 

        public void ListPlayers()
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }           
    }
}
