using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace NewGame
{
    internal class Program
    {
        static void Main()
        {
            string userInput;
            string result;
            Console.WriteLine("You are in a dark and forbidding place.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Type the following for help: Help");
            userInput = Console.ReadLine();

            //Klae's Work Section

            if ((userInput.ToLower() == "bonfire") || (userInput.ToLower() == "campfire"))
            {
                Console.WriteLine("You arrive at a small encampment\n\n It looks like it has been left on it own, the fire only just about to go out!");
                Thread.Sleep(1000);
                Console.WriteLine("What do you do? blow on the fire or leave it to go out?");
                Thread.Sleep(1000);
                Console.WriteLine("Say Blow to keep the fire alive or say Wait to let it go out");
                userInput = Console.ReadLine();

                if (userInput.ToLower() == "blow")
                {
                    Console.WriteLine("You choose to blow on it just at the right time!");
                    Thread.Sleep(1000);
                    Console.WriteLine("You only had just seconds before it went out");
                    Thread.Sleep(1000);

                    Console.WriteLine("Because you saved the bonfire it will remember to respawn you back here instead of the start");
                    int bonfire = 0; bonfire++;
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine("You idoit, you let it go out, the campfire will remember that!");
                    Thread.Sleep(1000);
                    Console.WriteLine("You lost a bonfire! you failed to save it.");
                    Thread.Sleep(1000);
                    Console.WriteLine("The campfire has decided to not respawn you here!");
                    Console.ReadLine();
                }

                //Aflie's Work

                if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("You quit the game");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (userInput.ToLower() == "help")
            {
                Console.WriteLine("Type the following to enter the game the game: Proceed");
                Console.WriteLine("Type the following to exit the game: Quit");
                Thread.Sleep(1000);
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "proceed")
                {
                    StartGame();
                }
                else
                {
                    Console.WriteLine("Go away");
                    Thread.Sleep(1000);
                    //Environment.Exit(0);
                }
            }
            else if (userInput.ToLower() == "proceed")
            {
                StartGame();
            }
            else
            {
                Console.WriteLine("Go away");
                Thread.Sleep(1000);
                //Environment.Exit(0);
            }

            static void StartGame()
            {
                string[] responses =
                {
                "\nThe world does not respond.",
                "\nThe wind carries your words away.",
                "\nNothing stirs.",
                "\nYou cannot do that here."
                };
                Random rand = new Random();
                string userInput;
                Console.Clear();
                Console.WriteLine("Proceeding.");
                Thread.Sleep(2000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.Write(".");
                Thread.Sleep(1000);
                Console.WriteLine("\nBeyond the stone walls of a kingdom long since forgotten,");
                Thread.Sleep(2000);
                Console.WriteLine("the world stretched wild and untamed beneath the sky.");
                Thread.Sleep(2000);
                Console.WriteLine("In a quiet clearing of swaying grass and ancient pines, a lone bonfire crackled against the cold dusk,");
                Thread.Sleep(2000);
                Console.WriteLine("its embers drifting like lost souls upon the wind.");
                Thread.Sleep(2000);
                Console.WriteLine("There, beside the fire, sat a weary traveler clad in rusted steel and silence,");
                Thread.Sleep(2000);
                Console.WriteLine("watching the distant castle loom over the horizon — vast, broken, and waiting.");
                Thread.Sleep(2000);


                bool atBonfire = true;
                while (atBonfire)
                {
                    Console.WriteLine("\n\nWhat would you like to do?");
                    Console.WriteLine("Type the following to help: Help\nThis will be available all throughout the game.");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "help")
                    {
                        Console.WriteLine("\n\nTo continue to rest at the bonfire type: Rest");
                        Console.WriteLine("To leave the bonfire type: Proceed");
                    }
                    else if (userInput.ToLower() == "rest")
                    {
                        Console.WriteLine("\n\nThe traveler remains seated as the fire shifts and sighs, its embers rising in slow, fading spirals.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Heat presses softly against worn armor, and for a brief moment, the world feels distant.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Beyond the treeline, the broken silhouette of the castle watches in silence, unmoving, patient.");
                        Thread.Sleep(2000);
                        Console.WriteLine("The bonfire does not judge. It only burns.");
                        Thread.Sleep(2000);
                    }
                    else if (userInput.ToLower() == "proceed")
                    {
                        Console.WriteLine("\n\nThe traveler rises slowly, as if the weight of the world clings to every joint of rusted armor.");
                        Thread.Sleep(2000);
                        Console.WriteLine("The bonfire flickers behind them, casting long, trembling shadows across the grass, but its warmth is left behind.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Ahead, the untamed field stretches toward darkening woods swallowed by time.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Would you like to explore the area? Y/N");
                        userInput = Console.ReadLine();
                        if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                        {
                            atBonfire = false;
                        }
                        else if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                        {
                            Console.WriteLine("The traveler remains by the bonfire, unmoving as the wind threads through the grass and the trees whisper in the distance.");
                        }
                        else
                        {
                            Console.WriteLine(responses[rand.Next(responses.Length)]);
                        }

                    }
                    else
                    {
                        Console.WriteLine(responses[rand.Next(responses.Length)]);
                    }
                }
                Console.WriteLine("..");

                Console.WriteLine("\n\nWhat would you like to do?");
                Console.WriteLine("Type the following to help: Help\nThis will be available all throughout the game.");
                userInput = Console.ReadLine();

                

                }





            }
        }
    }
}
