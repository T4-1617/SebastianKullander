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
            Random roll = new Random();
            Console.WriteLine("Vill du dra ett kort? J/N");
            char JN = Console.ReadKey().KeyChar;


            while (JN == 'j')
            {


                int x = roll.Next(0, 8);
                int y = roll.Next(0, 13);


                if (CardDeck[x, y] == false)
                { 

                    switch (x)
                {
                    case 0:
                        Console.WriteLine("ditt kort är hjärter");
                        break;

                    case 1:
                        Console.WriteLine("ditt kort är hjärter");
                        break;

                    case 2:
                        Console.WriteLine("ditt kort är spader");
                        break;

                    case 3:
                        Console.WriteLine("ditt kort är spader");
                        break;

                    case 4:
                        Console.WriteLine("ditt kort är ruter");
                        break;

                    case 5:
                        Console.WriteLine("ditt kort är ruter");
                        break;

                    case 6:
                        Console.WriteLine("ditt kort är klöver");
                        break;

                    case 7:
                        Console.WriteLine("ditt kort är klöver");
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

                Console.WriteLine("Vill du dra ett till kort? J/N");
                    JN = Console.ReadKey().KeyChar;

                }

                
            }

            

            while (JN == 'n')
            {
                Console.WriteLine("nope");
                break;
            }

        }
    }
}
