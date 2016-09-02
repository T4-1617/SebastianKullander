using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skriv in ditt namn:");
            string namn;
            namn = Console.ReadLine();

            for (int i = 0; i < namn.Length; i++)
            {
                switch (namn)
                {
                    case ('a'):
                        Console.Write("4");
                        break;
                        
                }
            }
        }
    }
}
