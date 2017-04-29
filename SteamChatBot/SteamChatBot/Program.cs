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

            new Callback<SteamUser.LoggedOnCallback>(OnLoggedOn, manager);

            isRunning = true;

            Console.WriteLine("Connecting to steam...");

            steamClient.Connect();

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

            Console.WriteLine("Connected to steam. Logging in {0}...", user);

            steamUser.LogOn(new SteamUser.LogOnDetails
            {
                Username = user,
                Password = pass,
            });
        }

        static void OnLoggedOn(SteamUser.LoggedOnCallback callback)
        {
            if (callback.Result != EResult.AccountLogonDenied)
            {
                Console.WriteLine("This account is SteamGuard protected.");
            }
            if (callback.Result != EResult.OK)
            {
                Console.WriteLine("Unable to log in to steam: {0}", callback.Result);
                isRunning = false;
                return;
            }
            Console.WriteLine("{0} Succesfully logged in!", user);
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}