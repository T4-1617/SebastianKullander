using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamKit2;
using System.IO;
using System.Threading;

namespace SteamChatBot
{
    class Program
    {
        static string user, pass;

        static SteamClient steamClient;
        static CallbackManager manager;
        static SteamUser steamUser;
        static SteamFriends steamFriends;

        static bool isRunning = false;

        static string authCode;
        static string twoFactor;

        static void Main(string[] args)
        {
            Console.Title = "A Bot";
            Console.WriteLine("CTRL+C exits the program.");

            Console.Write("Username: ");
            user = Console.ReadLine();

            Console.Write("Password: ");
            pass = Console.ReadLine();

            SteamLogIn();
        }
        static void SteamLogIn()
        {
            steamClient = new SteamClient();

            manager = new CallbackManager(steamClient);

            steamUser = steamClient.GetHandler<SteamUser>();
            steamFriends = steamClient.GetHandler<SteamFriends>();

            new Callback<SteamClient.ConnectedCallback>(OnConnected, manager);

            new Callback<SteamUser.LoggedOnCallback>(OnLoggedOn, manager);

            new Callback<SteamUser.AccountInfoCallback>(OnAccountInfo, manager);

            new Callback<SteamClient.DisconnectedCallback>(OnDisconnected, manager);

            new Callback<SteamFriends.FriendMsgCallback>(OnChatMessage, manager);

            manager.Subscribe<SteamUser.UpdateMachineAuthCallback>(OnMachineAuth);

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

            byte[] sentryHash = null;

            if (File.Exists("sentry.bin"))
            {
                byte[] sentryFile = File.ReadAllBytes("sentry.bin");

                sentryHash = CryptoHelper.SHAHash(sentryFile);
            }

            steamUser.LogOn(new SteamUser.LogOnDetails
            {
                Username = user,
                Password = pass,

                AuthCode = authCode,
                SentryFileHash = sentryHash,
                TwoFactorCode = twoFactor,
            });
        }

        static void OnLoggedOn(SteamUser.LoggedOnCallback callback)
        {
            if (callback.Result == EResult.AccountLogonDeniedNeedTwoFactorCode)
            {
                Console.Write("Please Enter In Your Two Factor Auth Code: ");
                twoFactor = Console.ReadLine();
                return;
            }
            
            if (callback.Result != EResult.OK)
            {
                Console.WriteLine("Unable to log in to steam: {0}", callback.Result);
                isRunning = false;
                return;
            }
            Console.WriteLine("{0} Succesfully logged in!", user);
            Console.WriteLine("Log in status: {0}", callback.Result);
        }

        static void OnMachineAuth(SteamUser.UpdateMachineAuthCallback callback)
        {
            Console.WriteLine("Updating sentry file...");

            byte[] sentryHash = CryptoHelper.SHAHash(callback.Data);

            File.WriteAllBytes("sentry.bin", callback.Data);

            steamUser.SendMachineAuthResponse(new SteamUser.MachineAuthDetails
            {
                JobID = callback.JobID,
                FileName = callback.FileName,
                BytesWritten = callback.BytesToWrite,
                FileSize = callback.Data.Length,
                Offset = callback.Offset,
                Result = EResult.OK,
                LastError = 0,
                OneTimePassword = callback.OneTimePassword,
                SentryFileHash = sentryHash,
            });

            Console.WriteLine("Done.");
        }

        static void OnDisconnected(SteamClient.DisconnectedCallback callback)
        {
            Console.WriteLine("{0} disconnected from steam, reconnecting in 5 seconds...", user);

            Thread.Sleep(TimeSpan.FromSeconds(5));

            steamClient.Connect();
        }

        static void OnAccountInfo(SteamUser.AccountInfoCallback callback)
        {
            steamFriends.SetPersonaState(EPersonaState.Online);


        }

        static void OnChatMessage(SteamFriends.FriendMsgCallback callback)
        {
            if (callback.EntryType == EChatEntryType.ChatMsg)
            {
                steamFriends.SendChatMessage(callback.Sender, EChatEntryType.ChatMsg, "Hello");
            }
            

        }
    }
}
