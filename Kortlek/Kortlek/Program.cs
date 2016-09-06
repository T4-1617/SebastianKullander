using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kortlek
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] kortlek = new bool[4, 13];

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 13; y++)
                {
                    kortlek[x, y] = false;
                }
            }
            Random roll = new Random();
            int kort = 52;
            while (kort > 0)
            {

                int y = roll.Next(0, 13);
                int x = roll.Next(0, 4);


                if (kortlek[x, y] == false)
                {
                    Console.WriteLine("tryck enter för att få ett kort");
                    Console.ReadLine();
                    switch (x)
                    {
                        case 0:
                            Console.WriteLine("ditt kort är hjärter");
                            break;

                        case 1:
                            Console.WriteLine("ditt kort är spader");
                            break;

                        case 2:
                            Console.WriteLine("ditt kort är ruter");
                            break;

                        case 3:
                            Console.WriteLine("ditt kort är klöver");
                            break;
                    }
                    
                        switch (y)
                        {
                            case 0:
                                Console.WriteLine("ess");
                                break;

                            case 10:
                                Console.WriteLine("knäckt");
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

                        kortlek[x, y] = true;
                        kort--;
                    
                    }

                }
            }
        }
    }
