using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapar kortleken
            bool[,] CardDeck = new bool[8, 13];
            int Card = 104;
            int Points = 0;
            Random roll = new Random();
            Console.WriteLine("Vill du dra ett kort? J/N");
            char JN = Console.ReadKey().KeyChar;
            bool Game = true;

            while (Game == true)
            {

                while (JN == 'j')
                {


                    int x = roll.Next(0, 8);
                    int y = roll.Next(0, 13);


                    if (CardDeck[x, y] == false)
                    {
                        
                        switch (x)
                        {
                            case 0:
                                Console.Write("ditt kort är hjärter ");
                                break;

                            case 1:
                                Console.Write("ditt kort är hjärter ");
                                break;

                            case 2:
                                Console.Write("ditt kort är spader ");
                                break;

                            case 3:
                                Console.Write("ditt kort är spader ");
                                break;

                            case 4:
                                Console.Write("ditt kort är ruter ");
                                break;

                            case 5:
                                Console.Write("ditt kort är ruter ");
                                break;

                            case 6:
                                Console.Write("ditt kort är klöver ");
                                break;

                            case 7:
                                Console.Write("ditt kort är klöver ");
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
                        Points += y + 1;
                        CardDeck[x, y] = true;
                        Card--;

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
    }
}
