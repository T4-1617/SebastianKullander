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

        static string twoFactor;

        static void Main(string[] args)
        {
            if (!File.Exists("chat.txt"))
            {
                File.Create("chat.txt").Close();
                File.WriteAllText("chat.txt", "abc | 123");
            }

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

            //new Callback<SteamClient.ConnectedCallback>(OnConnected, manager);
            //new Callback<SteamUser.LoggedOnCallback>(OnLoggedOn, manager);
            //new Callback<SteamUser.AccountInfoCallback>(OnAccountInfo, manager);
            //new Callback<SteamClient.DisconnectedCallback>(OnDisconnected, manager);
            //new Callback<SteamFriends.FriendMsgCallback>(OnChatMessage, manager);
            
            manager.Subscribe<SteamClient.ConnectedCallback>(OnConnected);
            manager.Subscribe<SteamUser.LoggedOnCallback>(OnLoggedOn);
            manager.Subscribe<SteamUser.AccountInfoCallback>(OnAccountInfo);
            manager.Subscribe<SteamClient.DisconnectedCallback>(OnDisconnected);
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

                TwoFactorCode = twoFactor,
                SentryFileHash = sentryHash,   
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
            string[] args;

            if (callback.EntryType == EChatEntryType.ChatMsg)
            {
                if (callback.Message.Length > 1)
                {
                    if (callback.Message.Remove(1) == "!")
                    {
                        string command = callback.Message;
                        if (callback.Message.Contains(" "))
                        {
                            command = callback.Message.Remove(callback.Message.IndexOf(' '));
                        }

                        switch (command)
                        {
                            #region send
                            case "!send"://!send friendname message
                                args = seperate(2, ' ', callback.Message);//args[0] = !send, args[1] = friendname, args[2] = message, args[3-4] = null;
                                Console.WriteLine("!send " + args[1] + args[2] + " command recieved. User: " + steamFriends.GetFriendPersonaName(callback.Sender));
                                if (args[0] == "-1")
                                {
                                    steamFriends.SendChatMessage(callback.Sender, EChatEntryType.ChatMsg, "Command syntax: !send [friend] [message]");
                                    return;
                                }
                                for (int i = 0; i < steamFriends.GetFriendCount(); i++)
                                {
                                    SteamID friend = steamFriends.GetFriendByIndex(i);//steamFriend.GetFriendByIndex(0) = 1243132134124;
                                    if (steamFriends.GetFriendPersonaName(friend).ToLower().Contains(args[1].ToLower()))//!send bob message or !send marley message
                                    {
                                        steamFriends.SendChatMessage(friend, EChatEntryType.ChatMsg, args[2]);
                                    }
                                }
                                    break;
                            #endregion
                            #region checkFriendlistStatus
                            case "!friends":
                                Console.WriteLine("!friends command recieved. User: " + steamFriends.GetFriendPersonaName(callback.Sender));
                                for (int i = 0; i < steamFriends.GetFriendCount(); i++ )
                                {
                                    SteamID friend = steamFriends.GetFriendByIndex(i);
                                    steamFriends.SendChatMessage(callback.Sender, EChatEntryType.ChatMsg, "Friend: " + steamFriends.GetFriendPersonaName(friend) + " State: " + steamFriends.GetFriendPersonaState(friend));
                                }
                                break;
                            #endregion
                        }
                    }
                    string rLine;
                    string trimmed = callback.Message;

                    //getting rid of all special characters so hello! = hello
                    char[] trim = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}', '\\', '|', ';', ':', '"', '\'', ',', '<', '.', '>', '/', '?' };

                    //30 characters
                    for (int i = 0; i < 30; i++)
                    {
                        trimmed = trimmed.Replace(trim[i].ToString(), "");
                    }

                    StreamReader sReader = new StreamReader("chat.txt");

                    while ((rLine = sReader.ReadLine()) != null)
                    {
                        string text = rLine.Remove(rLine.IndexOf('|') - 1);//message | response
                        string response = rLine.Remove(0, rLine.IndexOf('|') + 2);
                        
                        if(callback.Message.Contains(text))
                        {
                            steamFriends.SendChatMessage(callback.Sender, EChatEntryType.ChatMsg, response);
                            sReader.Close();
                            return;
                        }
                    }

                }
            }
            

        }

        public static string[] seperate(int number, char seperator, string thestring)
        {
            string[] returned = new string[4];

            int i = 0;

            int error = 0;

            int length = thestring.Length;

            foreach (char c in thestring)
            {
                if (i != number)
                {
                    if(error > length || number > 5)
                    {
                        returned[0] = "-1";
                        return returned;
                    }
                    else if (c == seperator)
                    {
                        returned[i] = thestring.Remove(thestring.IndexOf(c));
                        thestring = thestring.Remove(0, thestring.IndexOf(c) + 1);
                        i++;
                    }
                    error++;

                    if (error == length && i != number)
                    {
                        returned[0] = "-1";
                        return returned;
                    }
                }
                else
                {
                    returned[i] = thestring;
                }
            }
            return returned;
        }  
    }
}

//commands for the bot
//!send <SteamName> <YourMessage>
//!friends
