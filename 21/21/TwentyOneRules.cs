using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21
{
    public class TwentyOneRules
    {
        //checks for blackjack
        //dictionary of card values
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() //private can only be accessed inside a class, naming convention (underscore)
        {
            //instantiate a dictionary entry
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        private static int[] GetAllPossiblehandValues(List<Card> Hand)//passes in a hand
        {
            //returns integer array of possible values EX. ace and another card where ace could be 11 or 1 
            //
            int aceCount = Hand.Count(x => x.Face == Face.Ace);//finds out how many aces there are. returns count as variable aceCount
            int[] result = new int[aceCount + 1];//unique results
            int value = Hand.Sum(x => _cardValues[x.Face]);//looks the card up in the dictionary EX. face.six = 6
            result[0] = value;
            if (result.Length == 1) return result;
            for (int i = 1; i < result.Length; i++)//iterate through each different values of aces
            {
                value += (i * 10);//value is the lowest possible value at 1 
                result[i] = value;// ++ breakpoint for loop ++
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card>Hand)//Does this contain a face card and an ace card?
        {
            int[] possibleValues = GetAllPossiblehandValues(Hand);
            int value = possibleValues.Max();//maximum value in hand if player has two aces 
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card>Hand) //bust is over 21
        {
            int value = GetAllPossiblehandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card>Hand) //special dealer rules
        {
            int[] possibleHandValues = GetAllPossiblehandValues(Hand);
            foreach (int value in possibleHandValues) // checks in dealer hand total 
            {
                if (value > 16 && value < 22) //dealer will stay
                {
                    return true;
                }
            }
            return false; //dealer should not stay
        }

        public static bool? CompareHands (List<Card> Playerhand, List<Card> DealerHand) //comaprison of vairest possibilities 
        {
            int[] playerResults = GetAllPossiblehandValues(Playerhand);//all possible values for player & dealer
            int[] dealerResults = GetAllPossiblehandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).min();//filters list of results where int < 22 but gives the largest value //video 9
            int dealerScore = dealerResults.Where(x => x < 22).Max();//broken above when staying (bug!) >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null; //if both scores are equal return null
        }
    }
}
