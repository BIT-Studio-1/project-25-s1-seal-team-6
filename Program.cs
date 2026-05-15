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
                    Environment.Exit(0);
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
                Environment.Exit(0);
            }

            static void StartGame()
            {
                string[] inventory = new string[5];
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


                bool atIntroBonfire = true;
                while (atIntroBonfire)
                {
                    Console.WriteLine("\n\nWhat would you like to do?");
                    Console.WriteLine("Type the following for help: Help\nThis will be available all throughout the game.");
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

                        bool deciding = true;
                        while (deciding)
                        {
                            Console.WriteLine("Would you like to explore the area? Y/N");
                            userInput = Console.ReadLine();
                            if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                            {
                                atIntroBonfire = false;
                                deciding = false;
                            }
                            else if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                            {
                                Console.WriteLine("\nThe traveler remains by the bonfire, unmoving as the wind threads through the grass and the trees whisper in the distance.");
                                Thread.Sleep(1500);
                                deciding = false;
                            }
                            else
                            {
                                Console.WriteLine(responses[rand.Next(responses.Length)]);
                            }
                        }
                        }
                    else
                    {
                        Console.WriteLine(responses[rand.Next(responses.Length)]);
                    }
                }
                Console.WriteLine("The traveler presses onward, leaving the bonfire’s fading warmth behind as the grass grows taller and the wind grows colder.");
                Thread.Sleep(2000);
                Console.WriteLine("The land soon begins to change—wild fields giving way to broken stone paths half-swallowed by earth.");
                Thread.Sleep(2000);
                Console.WriteLine("Something vast begins to take shape.A wall.Not the castle itself, but the forgotten edge of a kingdom long sealed away from time.");
                Thread.Sleep(2000);
                Console.WriteLine("And there, set within its ruin, stands a massive iron gate. Rusted. Heavy. Unmoving.");
                Thread.Sleep(2000);
                Console.WriteLine("The gate does not welcome. It only remains. Waiting.");
                Thread.Sleep(2000);

                bool atGateBonfire = true;
                bool atGate = true;
                while (atGate)
                {
                    Console.WriteLine("Would you like to proceed? Y/N");
                    userInput = Console.ReadLine();

                    if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                    {
                        Console.WriteLine("\nThe iron gate groans as it yields, its ancient hinges screaming into silence...");
                        Thread.Sleep(2000);
                        Console.WriteLine("Beyond it lies the forgotten kingdom. The air grows heavy.");
                        Thread.Sleep(2000);
                        Console.WriteLine("A bonfire waits in the distance. Would you like to rest?");
                        Thread.Sleep(2000);

                        while (atGateBonfire)
                        {
                            Console.WriteLine("\nRest or Proceed?");
                            userInput = Console.ReadLine();
                            if (userInput.ToLower() == "rest")
                            {
                                Console.WriteLine("The traveler settles beside the bonfire as its warmth folds quietly into the cold air.");
                                Thread.Sleep(2000);
                                Console.WriteLine("For a brief moment, the world feels distant and still, as if even the shadows have learned to rest.");
                                Thread.Sleep(2000);
                                Console.WriteLine("You continue to enjoy the warmth of the bonfire.");
                                Thread.Sleep(2000);
                                Console.WriteLine("But a part of you feels like you are wasting time...");
                                Thread.Sleep(2000);
                            }
                            else if (userInput.ToLower() == "help")
                            {
                                Console.WriteLine("At the bonfire: Rest / Proceed");
                            }
                            else if (userInput.ToLower() == "proceed")
                            {
                                Console.WriteLine("The traveler leaves the warmth of the fire behind and steps deeper into the ruined kingdom.");
                                Thread.Sleep(2000);
                                Console.WriteLine("Somewhere ahead, unseen things stir in the dark.");
                                Thread.Sleep(2000);
                                atGateBonfire = false;
                                atGate = false;
                            }
                            else
                            {
                                Console.WriteLine(responses[rand.Next(responses.Length)]);
                            }
                        }
                    }
                    else if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                    {
                        Console.WriteLine("\nYou stare at the entrance of the kingdom.");
                        Console.WriteLine("The gate does not blame you.");
                        Thread.Sleep(2000);
                        Console.WriteLine("It is very intimidating.");
                    }
                    else if (userInput.ToLower() == "help")
                    {
                        Console.WriteLine("At the gate: Y/N");                        
                    }
                    else
                    {
                        Console.WriteLine(responses[rand.Next(responses.Length)]);
                    }
                }
                bool hasSword = false;
                Console.WriteLine("\nThe traveler presses onward, leaving the bonfire’s fading warmth behind.");
                Thread.Sleep(2000);
                Console.WriteLine("Something glints faintly beneath the pale light of the evening sky.");
                Thread.Sleep(2000);
                Console.WriteLine("Half-buried in the mud beside the path lies the corpse of a fallen knight.");
                Thread.Sleep(2000);
                Console.WriteLine("Its armor is split open with age and ruin, but one hand still clutches the hilt of a weathered blade.");
                Thread.Sleep(2000);
                Console.WriteLine("Would you like to collected the sword?");
                userInput = Console.ReadLine();
                if (userInput == "y" || userInput == "yes")
                {
                    inventory[0] = "Rusty Sword";
                    hasSword = true;
                    Console.WriteLine("You obtained: Rusty Sword");
                }
                else
                {
                    Console.WriteLine("You leave the sword behind.");
                }
                Console.WriteLine("You continue onward. Each step echoed unnaturally through the empty city. No voices remained here.");
                Thread.Sleep(2000);


                //if (hasSword)
                //{
                //    Console.WriteLine("\nYou draw the Rusty Sword.");
                //    Thread.Sleep(2000);
                //    Console.WriteLine("The creature hesitates.");
                //    Thread.Sleep(2000);
                //    Console.WriteLine("With a desperate swing, you cut the hollow down.");
                //}
                //else
                //{
                //    Console.WriteLine("\nYou have nothing to defend yourself with.");
                //    Thread.Sleep(2000);
                //    Console.WriteLine("The creature rushes forward.");
                //    Thread.Sleep(2000);
                //    Console.WriteLine("You barely escape with your life.");
                //}

            }

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

                }


            
        }
    }
}
