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
                    gameBoard[x, y] = false;//skapar spelplanen
                }
            }

            Random roll = new Random();
            int Ships = 4;
            while (Ships > 0)
            {

                int x = roll.Next(0, 7);
                int y = roll.Next(0, 5);
                gameBoard[x, y] = true;
                Ships--;//sätter ut skepp på spelplanen
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
                //    Console.WriteLine(); //Fel på denna kod verkar det som
                //for loop som skriver ut spelplanen i konsolen

            }
            Console.WriteLine("Skjut ner skeppen genom att använda rätt kordinater!");

            int shotCounter = 0;
            int shipCounter = 4;
            int cx = -1;
            int cy = -1;

            while (shipCounter > 0)//ska göra så att man fortsätter tills alla skepp är nedskjutna
                                   //vet ej om det funkar pga att programmet inte funkar
            {
                Console.WriteLine("X Kordinat:");
                cx = int.Parse(Console.ReadLine()) - 1;
                while (cx > 7 || cx < 0)
                //kontrollerar att man skrivit in korrekt värde
                {
                    if (cx > 7 || cy < 0)
                    {
                        Console.WriteLine("Kanonen räcker inte dit, det måste vara inom det tillåtna området(1-8)");
                        cx = int.Parse(Console.ReadLine()) - 1;
                        //om värdet inte är korrekt skickas man tillbaka
                    }
                    Console.WriteLine("Y Kordinat:");
                    cy = int.Parse(Console.ReadLine()) - 1;
                    while (cy > 5 || cy < 0)
                    {
                        if (cy > 5 || cy < 0)
                        {
                            Console.WriteLine("Kanonen räcker inte dit, det måste vara inom det tillåtna området(1-6)");
                            cy = int.Parse(Console.ReadLine()) - 1;
                            {
                                //    if (gameBoard[cx, cy] == true)
                                //    {
                                //        Console.WriteLine("BOOM CRASH POW!");

                                //        gameBoard[cx, cy] = false;
                                //        shotCounter++;
                                //        shipCounter--;
                                //        Console.WriteLine("skepp kvar: " + shipCounter);
                                //visar om man prickat rätt
                                //    }
                                //    else
                                //    {
                                //        Console.WriteLine("Illa, försök igen");
                                //        shotCounter++;
                                //visar om man missar
                                //    }

                                //programmet fortsätter att upprepa x kordinaten tills man skrivit in ett felaktigt värde och sedan skriver in
                                //kordinaten igen.
                                //även delen av progammet som ska skriva ut banan ger ett error jag inte kunde fixa
                                //klarade inte av att fixa programmet och jag sitter fast så skrev klart så som jag trodde att det skulle funka


                            }
                        }
                    }
                }
            }
        }
    }
}








