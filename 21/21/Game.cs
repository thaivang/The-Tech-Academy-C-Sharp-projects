using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public abstract class Game //abstract class cannot be instantiate (object) as it can only be inherited from 
    {

        //Design towards abstraction - tip
        //Instead of creating a name like 21Game then it will be only tied to one game
        //but a generic name like "Game" you can use for future projects
        public List<string> Players { get; set; } //property 
        public string Name { get; set; } 
        public string Dealer { get; set; }

        public abstract void Play(); //abstract methods can only exist in abstract class & any class that inherit "class game" must 
                                     //implement this method ->  "public abstract void Play();"

        public virtual void ListPlayers() //virtual method in abstract class, allows you to have your own implementation of numbers of players
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }           
    }
}
