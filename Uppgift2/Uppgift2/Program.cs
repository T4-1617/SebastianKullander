using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej vad heter du?");
            Console.Write("Skriv in ditt förnamn:");
            string namn = Console.ReadLine();

            Console.Write("skriv in ditt efternamn:");
            string efternamn = Console.ReadLine();

            Console.WriteLine("hej "+efternamn);
            Console.ReadLine();


        }
    }
}
