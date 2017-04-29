using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;

namespace ChatBot
{
    class Program
    {
        static string user, pass;
        static void Main(string[] args)
        {
            Console.Title = "A Bot";
            Console.WriteLine("CTRL+C exits the program.");

            Console.Write("username: ");
            user = Console.ReadLine();

            Console.Write("password: ")
            pass = Console.ReadLine();
        }
    }
}
