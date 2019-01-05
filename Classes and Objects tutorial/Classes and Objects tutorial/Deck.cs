using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects_tutorial
{
    public class Deck
    {
        //Constructors goes on the top of the class before the properties
        //Constructors assigning values to objects upon creation
        public Deck()
        {
            Cards = new List<Card>(); //Cards referring to the class which is hy data type is not needed

            //Easier solution to add all cards (52 cards) to the deck
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };
            foreach (string face in Faces) //loop through 4 times for each suits
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //during each loop a card is created, var ccard onlt exists in the loop
                    card.Suit = suit; //assign suit property, value of suit to each element in the list Suits
                    card.Face = face;
                    Cards.Add(card); //add new card to Cards list 
                }
            }

            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; } //class with data type card with property get set

    }
}
