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
                if (kortlek[x, y] != true) {
                    Console.WriteLine(x + " " + y);
                kortlek[x, y] = true;
                    kort--;
                }
            }
        }
    }
}
