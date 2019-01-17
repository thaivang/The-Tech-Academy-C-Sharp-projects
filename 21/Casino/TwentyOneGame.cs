using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Interfaces;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }
        
        public override void Play() //use override in method when inheriting abstract class
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)//Players is a property of game class
            {
                player.Hand = new List<Card>();// each new game, players hand is discarded
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();// dealer hand is discarded
            Dealer.Stay = false;
            Dealer.Deck = new Deck(); //each new game a new deck will be created to insured there is 52 cards, otherwise there is a partial deck for the nect game
            Dealer.Deck.Shuffle(); //shuffles deck for each game

            foreach (Player player in Players)//loops through each player placing a bet
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet!");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer) Console.WriteLine("Please enter digits only, no decimals.");
                }
                //int bet = Convert.ToInt32(Console.ReadLine());

                if (bet < 0)
                {
                    throw new FraudException();
                }
                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet) //successfullyBet == false
                {
                    return;//doesn't return anything, ends the method and goes to the while loop in program.cs
                }
                //dictionary is a collection of key value pair where player is the key and value is what they bet
                Bets[player] = bet; //player object
            }
            for (int i = 0; i < 2; i++) //cards are face up, loops through twice giving each player 2 cards
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.WriteLine("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)//i == , second round + checks for black if player has an ace card
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);//player wins
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]); //player wins 1/2 times the amount bet + player's bet
                            Bets.Remove(player);//removes player from game if dealer bust so player doesn't get paid twice
                            return; //round is over when player wins blackjack
                        }
                    }
                }
                Console.WriteLine("Dealer: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)//checks dealer for blackjack
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses!");//dealer gains all bets from player when dealer wins
                        foreach (KeyValuePair<Player, int> entry in Bets)//iterates through dictionary
                        {
                            Dealer.Balance += entry.Value;//assigns balance to everything
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players) //goes through each player to check if they want to stay or hit 
            {
                while (!player.Stay)//while not staying
                {
                    Console.WriteLine("Your cards are: ");
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0} ", card.ToString());
                    }
                    Console.WriteLine("\n\n Hit or stay?"); // == 
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "stay")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer == "hit")
                    {
                        Dealer.Deal(player.Hand);//prints card to console to player
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];// all bets from players goes to dealer balance
                        Console.WriteLine("{0} Busted! You lose your bet of {1}. Your balance is now {2}.", player.Name, Bets[player], player.Balance);
                        Console.WriteLine("Do you want to play again?"); //if player bust, ask to play again
                        answer = Console.ReadLine().ToLower();
                        if (answer == "yes" || answer == "yeah")
                        {
                            player.IsActivelyPlaying = true;
                            return;//return ends void program
                        }
                        else
                        {
                            player.IsActivelyPlaying = false;
                            return; 
                        }
                    }
                }
            }
            //dealer doesn't get any card until all the players get their cards and if they bust before the dealer they lose
            Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);//
            while (!Dealer.Stay && !Dealer.IsBusted)//continue to keep giving cards to the dealer 
            {
                Console.WriteLine("Dealer is hitting...");
                Dealer.Deal(Dealer.Hand);
                Dealer.IsBusted = TwentyOneRules.IsBusted(Dealer.Hand);//checks if busted then breaks
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);// checks if staying then breaks

            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.IsBusted)
            {
                Console.WriteLine("Dealer Busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)//if dealer is busted, all player is given their winnings
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);//prints out who won + entry is person, key is player, name is of player
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);//where (word) produces a list
                    //list of players . where (their name == the name in the dictionary ). grabs the balance of the person() and += what they bet * 2 //takes their balance and add what they get * 2
                    //loops through each key value pair and finds the player in the player's list that matches that key value pair 
                    Dealer.Balance -= entry.Value;//subtracts the bet from the dealer
                }
                return; //ends the round
            }
            //compares player hand to dealer's hand
            foreach (Player player in Players) //public static bool? 
            {
                bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand); //bool now can take the value null 
                if (playerWon == null)
                {
                    Console.WriteLine("Push! No one wins.");
                    player.Balance += Bets[player]; //player gets their bets back if null(tie)
                    //Bets.Remove(player);//removes bets from table
                }
                else if (playerWon == true)
                {
                    Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);//prints player name and the amount they won
                    player.Balance += (Bets[player] * 2);//player gets their bet back *(times) 2 
                    Dealer.Balance -= Bets[player]; //subtract from dealer balance
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}!", Bets[player]);
                    Dealer.Balance += Bets[player];//dealer wins all player bets and adds to balance
                }
                Console.WriteLine("Play again?"); //loops through if player won and ask for a new game 
                string answer = Console.ReadLine().ToLower();
                if (answer == "yes" || answer == "yeah")
                {
                    player.IsActivelyPlaying = true;
                }
                else
                {
                    player.IsActivelyPlaying = false;
                }
            }
        }
        public override void ListPlayers()
        {
            Console.WriteLine("21 Players");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
