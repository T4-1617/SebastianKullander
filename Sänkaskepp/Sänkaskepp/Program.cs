using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sänkaskepp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa spel plan
            //Sätta ut båtar
            //spelaren ska kunna mata in "kordinater"
            //ska bli true eller false
            //räkna antal försök

            bool[,] gameBoard = new bool[7, 5];

            for (int y = 0; y < 5; y++)
            {
                for (int x = 0; x < 7; x++)
                {
                    gameBoard[x, y] = false;
                }
            }

            Random roll = new Random();
            int Ships = 4;
            while (Ships > 0)
            {

                int x = roll.Next(0, 7);
                int y = roll.Next(0, 5);
                gameBoard[x, y] = true;
                Ships--;
                //}

                //for (int y = 0; y < 7; y++)
                //{
                //    for (int x = 0; x < 5; x++)
                //    {
                //        string Spot;
                //        if (gameBoard[x, y] == true)
                //        {
                //            Spot = " X ";
                //        }
                //        else
                //        {
                //            Spot = " O ";
                //        }
                //        Console.Write(Spot);
                //    }
                //    Console.WriteLine();

            }
            Console.WriteLine("Skjut ner skeppen genom att använda rätt kordinater!");

            int shotCounter = 0;
            int shipCounter = 4;
            int cx = -1;
            int cy = -1;

            while (shipCounter > 0)
            {
                Console.WriteLine("X Kordinat:");
                cx = int.Parse(Console.ReadLine()) - 1;
                while (cx > 7 || cx < 0)
                {
                    if (cx > 7 || cy < 0)
                    {
                        Console.WriteLine("Kanonen räcker inte dit, det måste vara inom det tillåtna området(1-8)");
                        cx = int.Parse(Console.ReadLine()) - 1;
                    }
                    Console.WriteLine("Y Kordinat:");
                    cy = int.Parse(Console.ReadLine()) - 1;
                    while (cy > 5 || cy < 0)
                    {
                        if (cy > 5 || cx < 0)
                        {
                            Console.WriteLine("Kanonen räcker inte dit, det måste vara inom det tillåtna området(1-6)");
                            cy = int.Parse(Console.ReadLine()) - 1;


                        }
                    }
                }
            }
        }
    }
}







