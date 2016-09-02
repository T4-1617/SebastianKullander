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
            
            
        }
    }
}
