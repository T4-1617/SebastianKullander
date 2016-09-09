using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static Random roll = new Random();
        static bool[,] CardDeck = new bool[16, 13];
        static int Card = 208;
        static int playerScore = 0;
        static int y;

        static void Main(string[] args)
        {
            
            int Points = 0;
            int dealerPoints = 0;
            // prints text and reads which key you press
            Console.WriteLine("Vill du dra ett kort? J/N");
            char JN = Console.ReadKey().KeyChar;
            bool Game = true;

            //when game is running
            while (Game == true)
            {
                //when pressed J dealer recieves a card while points = 0 and player recieves a card
                while (JN == 'j')
                {
                    if (Points == 0)
                    {
                        // Dealer picks a card
                        y = PickCard("Dealern");
                        dealerPoints += y + 1;

                    }


                    // Player picks a card
                    y = PickCard("Spelaren");
                    Points += y + 1;

                    //prints the points for the dealer and player
                    Console.WriteLine("\ndealern har {0} poäng", dealerPoints);
                    Console.WriteLine("du har {0} poäng", Points);


                    //if there is no more cards the game will stop
                    if (Card == 0)
                    {
                        Console.WriteLine("\ntyvärr inga fler kort finns, starta om programmet om du vill spela igen!");
                    }
                    //if there is cards left, ask if player wanna draw a new card
                    else
                    {
                        Console.WriteLine("\nVill du dra ett till kort? J/N");
                        JN = Console.ReadKey().KeyChar;
                    }
                }
                //while user press N do this
                while (JN == 'n')
                {
                    //if points = 21 print text and give player 3 points
                    if (Points == 21)
                    {
                        Console.WriteLine("Grattis du vann!");
                        playerScore += 3;
                        Console.WriteLine("du har {0} poäng", playerScore);
                    }
                    //if points is more than 21 give player -1 points
                    else if (Points > 21)
                    {
                        Console.WriteLine("Du sprack! bättre lycka nästa gång");
                        playerScore -= 1;
                        Console.WriteLine("du har {0} poäng", playerScore);
                    }
                    // if the dealers points is less than players, draw more cards
                    else if (dealerPoints < Points)
                    {
                        y = PickCard("Dealern");
                        dealerPoints += y + 1;

                        if (dealerPoints < Points)
                        {
                            y = PickCard("Dealern");
                            dealerPoints += y + 1;

                            if (dealerPoints < Points)
                            {
                                y = PickCard("Dealern");
                                dealerPoints += y + 1;

                            }
                        }
                    }
                    //if dealer gets more points than player, it wins. give -1 points
                    else if (dealerPoints > Points)
                    {
                        Console.WriteLine("Dealern fick mer poäng, du förlorade!");
                        playerScore -= 1;
                        Console.WriteLine("du har {0} poäng", playerScore);
                    }
                    //if dealer points is above 21 it loses, give player +1 points
                    if (dealerPoints > 21)
                    {
                        Console.WriteLine("Deakern blev tjock, grattis du vann!");
                        playerScore += 1;
                        Console.WriteLine("du har {0} poäng", playerScore);
                    }

                    else if (dealerPoints > Points)
                    {
                        Console.WriteLine("Dealern fick mer poäng, du förlorade!");
                        playerScore -= 1;
                        Console.WriteLine("du har {0} poäng", playerScore);
                    }
                    //asks player if the wanna play again, can press j for new card or n and game closes
                    Console.WriteLine("Vill du köra igen?");
                    JN = Console.ReadKey().KeyChar;

                    if (JN == 'n')
                    {
                        Game = false;
                        JN = ' ';
                    }
                    Points = 0;
                    dealerPoints = 0;
                }

            }



        }
        //roll the cards
        private static int PickCard(string target)
        {
            while (true)
            {
                int x = roll.Next(0, 16);
                int y = roll.Next(0, 13);

               
                if (CardDeck[x, y] == false)
                {

                    switch (x)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                            Console.Write("{0} fick kortet hjärter ", target);
                            break;

                        case 4:
                        case 5:
                        case 6:
                        case 7:
                            Console.Write("{0} fick kortet spader ", target);
                            break;

                        case 8:
                        case 9:
                        case 10:
                        case 11:
                            Console.Write("{0} fick kortet ruter ", target);
                            break;

                        case 12:
                        case 13:
                        case 14:
                        case 15:
                            Console.Write("{0} fick kortet klöver ", target);
                            break;

                    }

                    switch (y)
                    {
                        case 0:
                            Console.WriteLine("ess");
                            break;

                        case 10:
                            Console.WriteLine("knekt");
                            break;

                        case 11:
                            Console.WriteLine("dam");
                            break;

                        case 12:
                            Console.WriteLine("kung");
                            break;

                        default:
                            Console.WriteLine(y + 1);
                            break;


                    }

                    CardDeck[x, y] = true;
                    Card--;

                    return y;

                }
            }

        }
    }
}
