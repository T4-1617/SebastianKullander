using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        

            static Random random = new Random();

            static int randomNumber(int minVal, int maxVal)
            {
            int rndNum = random.Next(minVal, maxVal);
            return rndNum;
        }

        //Function for setting AI boats
        static void setAIBoats()
        {
                //Loop for assigning random X & Y values
                for (int i = 0; i < boatSpawn; i++)
                {
                    boatX[i] = randomNumber(0, 7);
                    boatY[i] = randomNumber(0, 5);
                }

                //Fill grid with empty space
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 7; x++)
                    {
                        gridAI[x, y] = false;
                    }
                }

                //Places boats
                for (int j = 0; j < boatSpawn; j++)
                {
                    gridAI[boatX[j], boatY[j]] = true;
                }
            }

            //For writing the grid
            static void writeGrid()
        {
                for (int y = 0; y < 5; y++)
                {
                    for (int x = 0; x < 7; x++)
                    {
                        string p = " ~ "; //Used to print

                        //if (gridAI[x, y] == false)
                        //{
                        //    p = " ~ ";
                        //}


                        Console.Write(p);
                    }

                    Console.WriteLine();
                }
            }

            //For sinking ships
            static void sinkShip()
        {
                Console.Write("\n\nEnter the X coordinate: ");
                int xCord = int.Parse(Console.ReadLine()) - 1;
                Console.Write("\nEnter the Y coordinate: ");
                int yCord = int.Parse(Console.ReadLine()) - 1;

                if (gridAI[xCord, yCord] == true)
                {
                    Console.WriteLine("\n\nHit!");
                    gridAI[xCord, yCord] = false;

                    hitCounter++;

                    if (hitCounter == boatSpawn)
                    {
                        gameSwitcher = false;
                        Console.WriteLine("You win!");
                    }
                }
                else
                {
                    Console.WriteLine("\nMiss!");
                    missCounter++;
                }

            }

            //START Vars
            static bool gameSwitcher = true;
            static int hitCounter = 0;
            static int missCounter = 0;
            static int boatSpawn = randomNumber(4, 6);
            static bool[,] gridAI = new bool[7, 5];
            //END Vars

            //Holds the X values for the spawned boats
            static int[] boatX = new int[boatSpawn];
            //Holds the Y values for the spawned boats
            static int[] boatY = new int[boatSpawn];

            static void Main(string[] args)
        {
                setAIBoats();

                //Game logic
                while (gameSwitcher == true)
                {
                    writeGrid();
                    sinkShip();
                }
            }
        }
    }

