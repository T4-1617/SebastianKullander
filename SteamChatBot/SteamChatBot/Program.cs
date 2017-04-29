using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;

namespace SteamChatBot
{
    class Program
    {
        static string user, pass;

        static SteamClient steamClient;
        static CallbackManager manager;
        static SteamUser steamUser;

        static bool isRunning = false;

        static void Main(string[] args)
        {
            Console.Title = "A Bot";
            Console.WriteLine("CTRL+C exits the program.");

            Console.Write("username: ");
            user = Console.ReadLine();

            Console.Write("password: ");
            pass = Console.ReadLine();

            SteamLogIn();
        }
        static void SteamLogIn()
        {
            steamClient = new SteamClient();

            manager = new CallbackManager(steamClient);

            steamUser = steamClient.GetHandler<SteamUser>();

            new Callback<SteamClient.ConnectedCallback>(OnConnected, manager);

            steamClient.Connect();

            isRunning = true;
            while (isRunning)
            {
                manager.RunWaitCallbacks(TimeSpan.FromSeconds(1));
            }
            Console.ReadKey();
        }
        static void OnConnected(SteamClient.ConnectedCallback callback)
        {
            if (callback.Result != EResult.OK)
            {
                Console.WriteLine("Unable to connect to steam: {0}", callback.Result);
                isRunning = false;
                return;
            }
        }
    }
}