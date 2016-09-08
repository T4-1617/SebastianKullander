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

        static void Main(string[] args)
        {
            //skapar kortleken
            int Points = 0;
            int dealerPoints = 0;
            Console.WriteLine("Vill du dra ett kort? J/N");
            char JN = Console.ReadKey().KeyChar;
            bool Game = true;

            while (Game == true)
            {

                while (JN == 'j')
                {

                    // Dealer picks a card
                    int y = PickCard("Dealern");
                    dealerPoints += y + 1;

                    // Player picks a card
                    y = PickCard("Spelaren");
                    Points += y + 1;


                    Console.WriteLine("\ndealern har {0} poäng", dealerPoints);
                    Console.WriteLine("du har {0} poäng", Points);



                    if (Card == 0)
                    {
                        Console.WriteLine("\ntyvärr inga fler kort finns, starta om programmet om du vill spela igen!");
                    }

                    else
                    {
                        Console.WriteLine("\nVill du dra ett till kort? J/N");
                        JN = Console.ReadKey().KeyChar;
                    }
                }

                while (JN == 'n')
                {
                    if (Points == 21)
                    {
                        Console.WriteLine("Grattis du vann!");
                    }

                    else if (Points > 21)
                    {
                        Console.WriteLine("Du sprack! bättre lycka nästa gång");
                    }
                    Console.WriteLine("du fick {0} poäng", Points);
                    Console.WriteLine("Vill du köra igen?");
                    JN = Console.ReadKey().KeyChar;

                    if (JN == 'n')
                    {
                        Game = false;
                        JN = ' ';
                    }
                    Points = 0;

                }

            }



        }

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
