using System.ComponentModel.Design;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace NewGame
{
    internal class Program
    {
        static string[] Inventory = new string[5];

        //Start of Klae's Work
        //Start of Artwork Section
        public static void Welcome()
        {
            Console.WriteLine("               __        __   _                            _                           \r\n               \\ \\      / /__| | ___ ___  _ __ ___   ___  | |_ ___                     \r\n                \\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\                    \r\n                 \\ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) |                   \r\n  _   _           \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/  _                 \r\n | |_| |__   ___  |  ___|_ _| | | ___ _ __   | |/ (_)_ __   __ _  __| | ___  _ __ ___  \r\n | __| '_ \\ / _ \\ | |_ / _` | | |/ _ \\ '_ \\  | ' /| | '_ \\ / _` |/ _` |/ _ \\| '_ ` _ \\ \r\n | |_| | | |  __/ |  _| (_| | | |  __/ | | | | . \\| | | | | (_| | (_| | (_) | | | | | |\r\n  \\__|_| |_|\\___| |_|  \\__,_|_|_|\\___|_| |_| |_|\\_\\_|_| |_|\\__, |\\__,_|\\___/|_| |_| |_|\r\n                                                           |___/                       ");
            Console.Write("\nPress Enter to start"); Console.ReadLine();
            Console.Clear();
        }
        public static void Death()
        {
            Console.WriteLine("    __   __            _                       _____     _ _          _ _ _ _      \r\n    \\ \\ / /__  _   _  | |__   __ ___   _____  |  ___|_ _(_) | ___  __| | | | |     \r\n     \\ V / _ \\| | | | | '_ \\ / _` \\ \\ / / _ \\ | |_ / _` | | |/ _ \\/ _` | | | |     \r\n      | | (_) | |_| | | | | | (_| |\\ V /  __/ |  _| (_| | | |  __/ (_| |_|_|_|     \r\n  ____|_|\\___/ \\__,_| |_| |_|\\__,_| \\_/ \\___| |_|  \\__,_|_|_|\\___|\\__,_(_|_|_)   _ \r\n |  _ \\  ___  __ _| |_| |__     __ ___      ____ _(_) |_ ___   _   _  ___  _   _| |\r\n | | | |/ _ \\/ _` | __| '_ \\   / _` \\ \\ /\\ / / _` | | __/ __| | | | |/ _ \\| | | | |\r\n | |_| |  __/ (_| | |_| | | | | (_| |\\ V  V / (_| | | |_\\__ \\ | |_| | (_) | |_| |_|\r\n |____/ \\___|\\__,_|\\__|_| |_|  \\__,_| \\_/\\_/ \\__,_|_|\\__|___/  \\__, |\\___/ \\__,_(_)\r\n                                                               |___/               ");
            Console.Write("\nPress Enter to Respawn"); Console.ReadLine();
            Console.Clear();
        }

        public static void Meadow()
        {
            Console.WriteLine("        ______\r\n       /     /\\\r\n      /     /  \\\r\n     /_____/----\\_    (  \r\n    \"     \"          ).  \r\n   _ ___          o (:') o   \r\n  (@))_))        o ~/~~\\~ o   \r\n                  o  o  o\r\n");
        }

        public static void Pending_Bonfire()
        {
            Console.WriteLine("=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n==============================================*#%*===========================================\r\n============================================*@@@@============================================\r\n===========================================@@##@+============================================\r\n==========================================@@###@=============================================\r\n=========================================*@####@%============================================\r\n====================================*#===@%#####@*===========================================\r\n===================================@@@===@######%@+==========================================\r\n==================================*@@%===@########@+=========================================\r\n==================================+@%@===@%#######%@*==**+===================================\r\n===================================+**===*@########%@+=+@@@*=================================\r\n=====================================+*===@###**####%@==*@%@+================================\r\n===================================*@@%===@%###**####@*==@#@+================================\r\n==================================#@#@====@%####**###%@==@@@=================================\r\n=================================+@##@====@#####**####@=*@*==================================\r\n=================================*@##@@++@@#####***##%@====+=================================\r\n=================================+@###%@@%######***##@*=+@@@=================================\r\n==================================@%###########****##@+=@%@#=================================\r\n===============================*+=*@###########****##@==@#%@+================================\r\n===============================@@==@%###*####*****###@+*@##%@*===============================\r\n==============================*@@#=@@###**##******####@@#####@@==============================\r\n=============================@@#@#+@###***#*******############%@+============================\r\n============================@@##%@@%#*****#*******##*#####**###%@============================\r\n===========================*@#######******************###****###@*===========================\r\n========================+**@@####**#******************##*****###@%****=======================\r\n======================*@@@#@@###*****************************###@%%@@@@+++++=================\r\n==================+**#@@@%*#@###*************************+***###@#*#@@@@%@@@@@*==============\r\n==============#@@@@@#%@@@@#*@@##*******+******++*******++***###@%**%@@#***%@@@@#=============\r\n============+@@@@@@****%@@@@@@@%#****#@@@@%@@@@@@@%@@@**@@@@%@@@@@@@@#**#@@@@@@@#+===========\r\n============%@@@@@@@@#@@@@%%%@@@@@@#@@****@@*#***@@**#@@@##%@@@%%@@@@@%@@#*%@@@@@@#==========\r\n==========*@@@@@%***%@@@@@@@@@%###@@##%*#*@%*%*%#%@@#*%#@@@%%%%@@@@@@@@@###@@@@@@@@#=========\r\n=========*@@@@@@@@%@@@@@@@@@@%%#%@@#%#*%*@@%#%*%%%%@%#*%%%@@%%@@@@@@@@###%@@@@@@@@@%=========\r\n=========%@@@@@@@@@@@@%%*#@@@@@@@@@@@%%%%@@%@@@@@@@@@%%%@@@%%##%@@@#*#%@@@@@@@@@@@@+=========\r\n=========*@@@@@@@@@@@@@@@%#@@@@%%%%#%@@@@@@@%######%@@@@%#%%%%@@%%@@@@@@@@@@@@@@@%+==========\r\n==========#@@@@@@@@@@@@@@@@@@@@@@@@@%##@@%*##%%@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@*=============\r\n============*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*==============\r\n================*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*================\r\n==================+*@@@@%*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%+========================\r\n===========================+#@@@@@@@@#*=*@@@@@@@@@@@@@*=+**%@@%#*++==========================\r\n===============================+++++======+*#%@@@%#**========================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================");
        }
        public static void RespawnART()
        {
            Console.WriteLine("              _____ _                  _          ____                                      _ \r\n             |_   _(_)_ __ ___   ___  | |_ ___   |  _ \\ ___  ___ _ __   __ ___      ___ __ | |\r\n               | | | | '_ ` _ \\ / _ \\ | __/ _ \\  | |_) / _ \\/ __| '_ \\ / _` \\ \\ /\\ / / '_ \\| |\r\n               | | | | | | | | |  __/ | || (_) | |  _ <  __/\\__ \\ |_) | (_| |\\ V  V /| | | |_|\r\n               |_| |_|_| |_| |_|\\___|  \\__\\___/  |_| \\_\\___||___/ .__/ \\__,_| \\_/\\_/ |_| |_(_)\r\n                                                                |_|                           ");
            Console.ReadLine();
            Console.WriteLine("Press enter to Respawn!");
            Console.Clear();

        }
        //End of Artwork Section
        
        public static void RespawnMain()
        {

            string userInput = Console.ReadLine(); //ADDED THIS TO FIX THE ERROR SO I CAN RUN PROGRAM :) -Alfie
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


        //End of Klae's Work Section

        //Alfie's Work
        public static void RespawnOne()
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

        //AJ's Work-Inventory
        public static void InventoryMenu()
        {
            bool isEmpty = true;
            foreach (string item in Inventory)
            {
                if (item != null)
                {
                    isEmpty = false;
                    break;
                }
            }

            if (isEmpty)
            {
                Console.WriteLine("Your inventory is currently empty");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Your items: ");
                foreach (string item in Inventory)
                {
                    if (item != null)
                    {
                        Console.WriteLine("- " + item);
                        Thread.Sleep(1000);
                    }
                }
            }
        }
        
        static void Main()
        {
            string userInput;
            string result;
            Welcome();
            Console.WriteLine("You are in a dark and forbidding place.");
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Type the following for help: Help");
            userInput = Console.ReadLine();

            
            if (userInput.ToLower() == "quit")
            {
                Console.WriteLine("You quit the game");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            else if (userInput.ToLower() == "proceed")
            {
                StartGame();
            }
            else if (userInput.ToLower() == "inv")
            {
                InventoryMenu();
                Thread.Sleep(1000);
                Console.WriteLine("What did you expect, you haven't even started yet");
                Thread.Sleep(1000);
                Console.WriteLine("Starting now");
                Thread.Sleep(1000);
                StartGame();
            }

            else if (userInput.ToLower() == "help")
            {
                Console.WriteLine("Type the following to enter the game the game: Proceed");
                Console.WriteLine("Type the following to exit the game: Quit");
                Console.WriteLine("Type Inv to view your inventory");
                Thread.Sleep(1000);
                userInput = Console.ReadLine();
                if (userInput.ToLower() == "proceed")
                {
                    StartGame();
                }                
                else if (userInput.ToLower() == "inv")
                {
                    InventoryMenu();
                    Thread.Sleep(5000);
                    StartGame();
                }
                else
                {
                    Console.WriteLine("Go away");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
            }

            static void StartGame()
            {
                int player, BKknight;
                int playerHealth = 100;
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

                    else if (userInput.ToLower() == "inv")
                    {
                        InventoryMenu();
                        Thread.Sleep(1000);
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
                Console.WriteLine("\n\nThe traveler presses onward, leaving the bonfire’s fading warmth behind as the grass grows taller and the wind grows colder.");
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
                                RespawnOne();
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
                        Thread.Sleep(2000);
                    }

                    else if (userInput.ToLower() == "inv")
                    {
                        InventoryMenu();
                        Thread.Sleep(1000);
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
                Console.WriteLine("Half-buried in stone beside the path lies the corpse of a fallen knight.");
                Thread.Sleep(2000);
                Console.WriteLine("Its armor is split open with age and ruin, but one hand still clutches the hilt of a weathered blade.");
                Thread.Sleep(2000);
                Console.WriteLine("Would you like to collected the sword? Y/N");
                userInput = Console.ReadLine();
                if (hasSword == false && userInput.ToLower() == "y" || userInput.ToLower() == "yes")
                {
                    Inventory[0] = "Rusty Sword";
                    hasSword = true;
                    Console.WriteLine("\nYou obtained: Rusty Sword");
                }
                else
                {
                    Console.WriteLine("\nYou leave the sword behind.");
                }
                Console.WriteLine("\n\nYou continue onward. Each step echoed unnaturally through the empty city. No voices remained here.");
                Thread.Sleep(2000);
                Console.WriteLine("The traveler slows as the narrow street opens into a ruined courtyard choked with weeds and fallen stone.");
                Thread.Sleep(2000);
                Console.WriteLine("At its center stands a lone figure clad in blackened armor, motionless beneath the pale light filtering through the clouds above.");
                Thread.Sleep(2000);
                Console.WriteLine("For a moment, it seems no more alive than the statues scattered throughout the kingdom.\nThen the knight moves.");
                Thread.Sleep(2000);
                Console.WriteLine("Beneath the shattered visor, two faint embers flicker within the darkness where eyes should have been.");
                Thread.Sleep(2000);
                Console.WriteLine("Its blade rises slowly toward the traveler, trembling in decayed hands.\nThe kingdom is no longer empty..");
                Thread.Sleep(2000);
                bool blackKnightDefeated = false;
                
                while (blackKnightDefeated == false)
                {
                    int BKhealth = 100;
                    playerHealth = 100;
                    //Chan's

                    if (hasSword) //sword combat
                    {
                        
                        while (playerHealth > 0 && BKhealth > 0)
                        {
                            Console.WriteLine("You fight with the Rusty Sword");
                            Console.WriteLine("\n------------------------------------------------");
                            Console.WriteLine($"Your Health: {playerHealth}");
                            Console.WriteLine($"Black Knight Health: {BKhealth}");
                            Console.WriteLine("------------------------------------------------");

                            Console.WriteLine("Choose an action:");
                            Console.WriteLine("1. Attack");
                            Console.WriteLine("2. Heavy Attack");
                            Console.WriteLine("3. Defend");

                            string choice = Console.ReadLine().ToLower();

                            // PLAYER TURN
                            if (choice == "1" || choice == "attack")
                            {
                                int damage = rand.Next(15, 26);

                                Console.WriteLine("You slash the Black Knight!");
                                Console.WriteLine($"You deal {damage} damage!");

                                BKhealth -= damage;
                            }
                            else if (choice == "2" || choice == "heavy attack")
                            {
                                int hitChance = rand.Next(0, 2);

                                if (hitChance == 1)
                                {
                                    int damage = rand.Next(30, 51);

                                    Console.WriteLine("Your heavy attack lands!");
                                    Console.WriteLine($"You deal {damage} damage!");

                                    BKhealth -= damage;
                                }
                                else
                                {
                                    Console.WriteLine("Your heavy attack misses!");
                                }
                            }
                            else if (choice == "3" || choice == "defend")
                            {
                                Console.WriteLine("You brace for the Black Knight's attack.");
                            }

                            else if (choice == "inv" || choice == "inv")
                            {
                                Console.WriteLine("You bravely check your inventory mid combat");
                                InventoryMenu();
                            }

                            else
                            {
                                Console.WriteLine("You hesitate and lose your chance to act.");
                            }


                            if (BKhealth <= 0)
                            {
                                break;
                            }
                            Thread.Sleep(1500);


                            //Enemy

                            int enemyAttack = rand.Next(0, 3);

                            if (enemyAttack == 0)
                            {
                                int damage = 20;

                                if (choice == "3" || choice == "defend")
                                {
                                    damage /= 2;

                                    Console.WriteLine("You block part of the attack!");
                                }

                                Console.WriteLine("The Black Knight slashes you!");
                                Console.WriteLine($"You take {damage} damage!");

                                playerHealth -= damage;
                            }
                            else if (enemyAttack == 1)
                            {
                                Console.WriteLine("The Black Knight misses!");
                            }
                            else
                            {
                                int damage = 30;

                                Console.WriteLine("The Black Knight performs a heavy strike!");
                                Console.WriteLine($"You take {damage} damage!");

                                playerHealth -= damage;
                            }

                            Thread.Sleep(1500);
                            Console.WriteLine("------------------------------------------------");
                        }

                        if (playerHealth <= 0)
                        {
                            Death();
                            Console.WriteLine("You Died...");
                            RespawnOne();
                            
                        }
                        else if (BKhealth <= 0)
                        {
                            Console.WriteLine("Victory Achieved");
                            blackKnightDefeated = true;
                        }
                    }
                    else //fist combat
                    {
                        Console.WriteLine("\nYou chose not to take the sword.");
                        Thread.Sleep(1500);
                        Console.WriteLine("Your fists are all you have.");
                        Thread.Sleep(1500);

                        while (playerHealth > 0 && BKhealth > 0)
                        {
                            Console.WriteLine("\n------------------------------------------------");
                            Console.WriteLine($"Your Health: {playerHealth}");
                            Console.WriteLine($"Black Knight Health: {BKhealth}");
                            Console.WriteLine("------------------------------------------------");

                            Console.WriteLine("You stand bare-handed before the Black Knight.");

                            Console.WriteLine("1. Punch");
                            Console.WriteLine("2. Heavy Punch");
                            Console.WriteLine("3. Defend");

                            string choice = Console.ReadLine().ToLower();

                            
                            if (choice == "1" || choice == "punch")
                            {
                                int damage = rand.Next(5, 11);

                                Console.WriteLine("You punch Black Knight!");
                                Console.WriteLine($"You deal {damage} damage!");

                                BKhealth -= damage;
                            }
                            else if (choice == "2" || choice == "heavy punch")
                            {
                                int hitChance = rand.Next(0, 2);

                                if (hitChance == 1)
                                {
                                    int damage = rand.Next(10, 25);

                                    Console.WriteLine("Your heavy punch lands!");
                                    Console.WriteLine($"You deal {damage} damage!");

                                    BKhealth -= damage;
                                }
                                else
                                {
                                    Console.WriteLine("Your punch misses");
                                }
                            }
                            else if (choice == "3" || choice == "defend")
                            {
                                Console.WriteLine("You raise your fists defensively.");
                            }
                            else
                            {
                                Console.WriteLine("You hesitated and lose your chance to act");
                            }

                            if (BKhealth <= 0)
                            {
                                break;
                            }

                            Thread.Sleep(1000);

                            int enemyAttack = rand.Next(0, 3);

                            if (enemyAttack == 0) {
                                int damage = 20;

                                if (choice == "3" || choice == "defend")
                                    {
                                        damage /= 2;

                                        Console.WriteLine("You block part of the attack!");
                                    }

                                Console.WriteLine("The Black Knight slashes you!");
                                Console.WriteLine($"You take {damage} damage!");

                                playerHealth -= damage;
                            }
                            else if (enemyAttack == 1)
                            {
                                Console.WriteLine("The Black Knight misses!");
                            }
                            else
                            {
                                int damage = 30;

                                if (choice == "3" || choice == "defend")
                                {
                                    damage /= 2;

                                    Console.WriteLine("You absorb part of the heavy strike!");
                                }

                                Console.WriteLine("The Black Knight performs a heavy strike!");
                                Console.WriteLine($"You take {damage} damage!");

                                playerHealth -= damage;
                            }

                            Thread.Sleep(1500);

                            if (playerHealth <= 0)
                            {
                                Console.WriteLine("You Died...");
                                RespawnOne();
                                if (hasSword == false)
                                {
                                    Console.WriteLine("\nBeside the bonfire, the Rusty Sword still rests where you left it.");
                                    Thread.Sleep(2000);
                                    Console.WriteLine("Will you take it this time? Y/N");

                                    userInput = Console.ReadLine().ToLower();

                                    if (userInput == "y" || userInput == "yes")
                                    {
                                        hasSword = true;
                                        Inventory[0] = "Rusty Sword";

                                        Console.WriteLine("\nYou obtained: Rusty Sword");
                                        Thread.Sleep(1500);
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nYou leave the sword behind once more.");
                                        Thread.Sleep(1500);
                                    }
                                }
                            }
                            else if (BKhealth <= 0)
                            {
                                Console.WriteLine("Victory Achieved");
                                blackKnightDefeated = true;
                            }
                        }
                    }
                }              
                


                //if (playerHealth <= 0) Commented out by Klae E. Possible Repeat error.
                //{
                //    Death();
                //    //Console.WriteLine("You Died...");
                //    RespawnOne();
                //}
                //else if (BKhealth <= 0)
                //{
                //    Console.WriteLine("Victory Achieved");
                //}
                Console.WriteLine("\n\nThe black knight groans as he falls to his knees");
                Thread.Sleep(2000);
                Console.WriteLine("His body turns to dust, floating in the air.");
                Thread.Sleep(2000);
                Console.WriteLine("You have absorbed the Black Knight's soul and gained +25 health");
                Console.WriteLine("Max health total: 125HP");
                Thread.Sleep(2000);
                Console.WriteLine("\nYou proceed into the kingdom, past where the black knight once lay.");
                Thread.Sleep(2000);
                Console.WriteLine("Beyond the drifting fog, a vast cathedral rose above the kingdom like the corpse of a forgotten god.");
                Thread.Sleep(2000);
                Console.WriteLine("Its spires clawed toward the heavens, while shattered stained glass glimmered faintly beneath the sky.");
                Thread.Sleep(2000);
                Console.WriteLine("The great doors stood partially open, though it didn't seem inviting.");
                Thread.Sleep(2000);
                Console.WriteLine("A cold wind spilled from within the cathedral halls, carrying the scent of ash and something long left to rot.");
                Thread.Sleep(2000);
                Console.WriteLine("Would you like to enter?");
                int maxHealth = 125;
                bool cathedralChoiceMade = false;
                while (cathedralChoiceMade == false)
                {
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "y" || userInput.ToLower() == "yes" || userInput.ToLower() == "proceed")
                    {
                        cathedralChoiceMade = true;
                        Console.WriteLine("\n\nYou push against the cathedral doors with both hands. The ancient wood groans as the entrance slowly opens further.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Rows of broken benches stretch endlessly across the vast cathedral hall, cloaked in dust and silence..");
                        Thread.Sleep(2000);
                        Console.WriteLine("At the center of the cathedral, before a ruined altar, a lone figure kneels motionless.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Its body is thin and wrapped in torn black cloth stained with age. Twin daggers rest at its sides, their metal darkened like burnt silver.");
                        Thread.Sleep(2000);
                        Console.WriteLine("For a moment, the figure appears lifeless. Then the sound reaches you.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Breathing. Slow. Hollow. Wrong..");
                        Thread.Sleep(2000);
                        Console.WriteLine("“You should not have entered this place” a rasping voice whispers.");
                        Thread.Sleep(2000);
                        Console.WriteLine("The kneeling figure slowly rose from before the ruined altar. Beneath the hood, two pale eyes opened like dying embers in the dark.");
                        Thread.Sleep(2000);
                        bool assassinDefeated = false;
                        while (assassinDefeated == false)
                        {
                            playerHealth = 125;
                            int assassinHealth = 115;

                            Console.WriteLine("\nThe Undead Assassin waits before the ruined altar...");
                            Thread.Sleep(2000);

                            //Chan's work 

                            while ((playerHealth > 0) && (assassinHealth > 0))
                            {
                                
                                Console.WriteLine("---------------------------------------");
                                Console.WriteLine($"Your HP: {playerHealth}");
                                Console.WriteLine($"Assassin HP: {assassinHealth}");
                                Console.WriteLine("---------------------------------------");
                                Thread.Sleep(1000);

                                Console.WriteLine("Choose your action:");
                                Console.WriteLine("1. Slash");
                                Console.WriteLine("2. Heavy Strike");
                                Console.WriteLine("3. Dodge");
                                Console.WriteLine("4. Parry");

                                string choice = Console.ReadLine().ToLower();

                                //player

                                if (choice == "1" || choice == "slash")
                                {
                                    int damage = rand.Next(18, 31);

                                    Console.WriteLine("\nYou slash the Assassin!");
                                    Console.WriteLine($"You deal {damage} damage!");

                                    assassinHealth -= damage;
                                }
                                else if (choice == "2" || choice == "heavy strike")
                                {
                                    int hitChance = rand.Next(0, 100);

                                    if (hitChance < 60)
                                    {
                                        int damage = rand.Next(35, 51);

                                        Console.WriteLine("\nYour heavy strike lands!");
                                        Console.WriteLine($"You deal {damage} damage!");

                                        assassinHealth -= damage;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThe Assassin dodges your heavy strike!");
                                    }
                                }
                                else if (choice == "3" || choice == "dodge")
                                {
                                    Console.WriteLine("\nYou prepare to dodge.");
                                }
                                else if (choice == "4" || choice == "parry")
                                {
                                    Console.WriteLine("\nYou ready your blade to parry.");
                                }
                                else
                                {
                                    Console.WriteLine("\nYou hesitate...");
                                }

                                if (assassinHealth <= 0)
                                    break;

                                Thread.Sleep(1500);

                                //Enemy

                                int assassinAttack = rand.Next(0, 4);

                                if (assassinAttack == 0)
                                {
                                    int damage = 20;

                                    Console.WriteLine("\nThe Assassin rushes forward with twin daggers!");

                                    if (choice == "3" || choice == "dodge")
                                    {
                                        Console.WriteLine("You dodge the attack!");
                                    }
                                    else if (choice == "4" || choice == "parry")
                                    {
                                        Console.WriteLine("PARRY SUCCESSFUL!");
                                        Console.WriteLine("The Assassin is staggered!");

                                        assassinHealth -= 15;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You take {damage} damage!");
                                        playerHealth -= damage;
                                    }
                                }

                                else if (assassinAttack == 1)
                                {
                                    int damage = 35;

                                    Console.WriteLine("\nThe Assassin vanishes into the shadows!");

                                    if (choice == "3" || choice == "dodge")
                                    {
                                        Console.WriteLine("You narrowly evade the ambush!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("A blade pierces your side!");
                                        Console.WriteLine($"You take {damage} damage!");

                                        playerHealth -= damage;
                                    }
                                }

                                else if (assassinAttack == 2)
                                {
                                    Console.WriteLine("\nThe Assassin circles cautiously...");
                                }

                                else
                                {
                                    int damage = 45;

                                    Console.WriteLine("\nThe Assassin performs a deadly execution strike!");

                                    if (choice == "4" || choice == "parry")
                                    {
                                        Console.WriteLine("You deflect the execution strike!");
                                        assassinHealth -= 20;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"You take {damage} damage!");
                                        playerHealth -= damage;
                                    }
                                }

                                Thread.Sleep(1500);
                            }

                            
                            if (playerHealth <= 0)
                            {
                                Console.WriteLine("You Died...");
                                Thread.Sleep(2000);
                                Console.WriteLine("\nYou awaken beside the cathedral entrance.");
                                Thread.Sleep(2000);
                            }
                            else if (assassinHealth <= 0)
                            {
                                Console.WriteLine("Victory Achieved");
                                assassinDefeated = true;
                                Thread.Sleep(2000);
                                Console.WriteLine("You have absorbed the Undead Assassin's soul and gained +25 health");
                                Console.WriteLine("Max health total: 150HP");
                                Thread.Sleep(2000);
                                playerHealth = 150;
                                maxHealth = 150;
                                Console.WriteLine("A new weapon lays on the altar where the Undead Assassin once knelt");
                                Thread.Sleep(2000);
                                Console.WriteLine("A long, sharp blade.");
                                Thread.Sleep(2000);
                                Console.WriteLine("Would you like to collect it?");
                                Thread.Sleep(2000);                                
                                bool weaponChoiceMade = false;
                                while (weaponChoiceMade == false)
                                {
                                    userInput = Console.ReadLine().ToLower();
                                    if (userInput == "y" || userInput == "yes")
                                    {
                                        hasSword = true;
                                        Inventory[1] = "Claymore";
                                        Console.WriteLine("\nYou obtained: Claymore");
                                        Thread.Sleep(1500);
                                        weaponChoiceMade = true;
                                    }
                                    else if (userInput == "n" || userInput == "no")
                                    {
                                        Console.WriteLine("\nYou continue onwards with your Rusty Sword");
                                        weaponChoiceMade = true;
                                    }
                                    else if (userInput == "help")
                                    {
                                        Console.WriteLine("\nType Yes to collect the Claymore");
                                        Console.WriteLine("Type No to leave it behind");
                                    }
                                    else
                                    {
                                        Console.WriteLine(responses[rand.Next(responses.Length)]);
                                    }
                                }
                            }
                        }
                    }

                    else if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                    {
                        cathedralChoiceMade = true;
                        Console.WriteLine("You continue onward, ignoring the cathedral..");
                        playerHealth = 125;
                    }
                    else if (userInput.ToLower() == "help")
                    {
                        Console.WriteLine("To enter the cathedral type: Proceed");
                        Console.WriteLine("To ignore the cathedral type: No");
                    }
                    else
                    {
                        Console.WriteLine(responses[rand.Next(responses.Length)]);
                    }
                }
                Console.WriteLine("The cathedral fades into the distance behind you");
                Thread.Sleep(2000);
                Console.WriteLine("Cold wind swept through the empty streets, stirring ash and dust across the broken stone paths.");
                Thread.Sleep(2000);
                Console.WriteLine("Far above, the shattered spires of the cathedral faded slowly into the gray mist, swallowed by distance and silence.");
                Thread.Sleep(2000);
                Console.WriteLine("You soon reach a sign pointing towards a place called Shattered Peaks");
                Thread.Sleep(2000);
                Console.WriteLine("And a bonfire softly flickers flame into the air.. Would you like to rest?");
                bool atSPeaksBonfire = true;
                while (atSPeaksBonfire == true)
                {
                    Console.WriteLine("\n\nWhat would you like to do?");
                    userInput = Console.ReadLine();
                    if (userInput.ToLower() == "help")
                    {
                        Console.WriteLine("\n\nTo rest at the bonfire type: Rest");
                        Console.WriteLine("To leave the bonfire type: Proceed");
                    }
                    else if (userInput.ToLower() == "rest")
                    {
                        Console.WriteLine("\n\nThe traveler sits as the fire shifts and sighs, its embers rising in slow, fading spirals.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Heat presses softly against worn armor, and for a brief moment, the world feels distant.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Beyond the treeline, the broken silhouette of the castle watches in silence, unmoving, patient.");
                        Thread.Sleep(2000);
                        Console.WriteLine("The bonfire does not judge. It only burns.");
                        Thread.Sleep(2000);
                    }

                    else if (userInput.ToLower() == "inv")
                    {
                        InventoryMenu();
                        Thread.Sleep(1000);
                    }
                    else if (userInput.ToLower() == "proceed")
                    {
                        Console.WriteLine("\n\nThe traveler rises slowly, as if the weight of the world clings to every joint of rusted armor.");
                        Thread.Sleep(2000);
                        Console.WriteLine("The bonfire flickers behind them, casting long, trembling shadows across the grass, but its warmth is left behind.");
                        Thread.Sleep(2000);
                        Console.WriteLine("Ahead, snow and wilderness awaits.");
                        Thread.Sleep(2000);
                        atSPeaksBonfire = false;
                    }
                    else
                    {
                        Console.WriteLine(responses[rand.Next(responses.Length)]);
                    }
                }
                Console.WriteLine("...");
                
                
                //Kobe// 3rd boss fight============================================================================================
                //Console.WriteLine("\nThe Undead Assassin collapses to the frozen stone, its blade slipping from lifeless fingers.\".");
                //Thread.Sleep(2000);

                //Console.WriteLine("Its body slowly turns to ash beneath the Cathedral floor.");
                //Thread.Sleep(2500);

                //Console.WriteLine("The Cathedral Hall become silent once more.");
                //Thread.Sleep(2500);

                //Console.WriteLine("Only the distant howl of wind remains.");
                //Thread.Sleep(2500);

                //Console.WriteLine("\nYou absorb the Undead Assasin's Soul.");
                //Thread.Sleep(2500);

                //Console.WriteLine("Max health increased to 150HP");
                //Thread.Sleep(2500);

                //playerHealth = 150; COMMENTED OUT AS PLAYER HEALTH ONLY GOES TO 150 IF THEY FIGHT CATHEDRAL BOSS, OTHERWISE HESLTH REMAINS AT 125HP -Alfie :)

                //Console.WriteLine("\nThe traveler leaves the Cathedral Hall behind.");
                //Thread.Sleep(2500); COMMENTED OUT AS THIS ALREADY HAPPENS IN MY LOOP -Alfie

                Console.WriteLine("Beyond the kingdom walls, the world stretches into a cold and broken wilderness.");
                Thread.Sleep(3000);

                Console.WriteLine("Days seem to pass beneath dark skies and endless fog.");
                Thread.Sleep(3000);

                Console.WriteLine("The roads ahead are buried beneath snow and shattered stone.");
                Thread.Sleep(3000);

                Console.WriteLine("Far in the distance...");
                Thread.Sleep(2000);

                Console.WriteLine("Towering mountains rise beyond the horizon.");
                Thread.Sleep(2500);
                
                Console.WriteLine("\nNEW LOCATION UNLOCKED");
                Console.WriteLine("\n SHATTERED PEAKS");
               
                Console.WriteLine("\nJagged cliffs pierce the heavens like broken blades.");
                Thread.Sleep(3000);

                Console.WriteLine("Ruined bridges cling desperately to the mountainside.");
                Thread.Sleep(3000);

                Console.WriteLine("Snow falls endlessly across the ancient paths.");
                Thread.Sleep(3000);

                Console.WriteLine("Even the wind here sounds dead.");
                Thread.Sleep(3000);

                Console.WriteLine("\nThe traveler slowly climbs the frozen trail.");
                Thread.Sleep(3000);

                Console.WriteLine("Every step crunches against ice and ash.");
                Thread.Sleep(3000);

                Console.WriteLine("At the peak of the mountain...");
                Thread.Sleep(1000);

                Console.WriteLine("A lone figure stands motionless within the blizzard.");
                Thread.Sleep(1000);

                Console.WriteLine("A massive greatsword rests against the frozen ground.");
                Thread.Sleep(1000);

                Console.WriteLine("Black armor, cracked and consumed by darkness, reflects the pale moonlight.");
                Thread.Sleep(1000);

                Console.WriteLine("\nThe figure slowly turns toward you.");
                Thread.Sleep(1000);

                Console.WriteLine("Two glowing blue eyes burn beneath its broken helm.");
                Thread.Sleep(1000);

                Console.WriteLine("\n\"Another soul climbs the mountain of the dead...\"");
                Thread.Sleep(1000);

                Console.WriteLine("\nThe snowstorm grows violent.");
                Thread.Sleep(1000);

                Console.WriteLine("Dark abyssal flames begin to spread across the ice.");
                Thread.Sleep(1000);

                Console.WriteLine("\nThe warrior lifts its blade.");
                Thread.Sleep(1000);

                Console.WriteLine("\n\"Then let this peak become your grave.\"");
                Thread.Sleep(1000);

                Console.WriteLine("\n=======================================");
                Console.WriteLine("           BOSS ENCOUNTER");
                Console.WriteLine("             ABYSSWALKER");
                Console.WriteLine("=======================================");
                Thread.Sleep(4000);
                
                bool abysswalkerDefeated = false;

                while (abysswalkerDefeated == false)
                {
                    int abyssHealth = 160;
                    //playerHealth = 150; COMMENTED OUT AS PLAYER HEALTH ONLY GOES TO 150 IF THEY FIGHT CATHEDRAL BOSS, OTHERWISE HESLTH REMAINS AT 125HP -Alfie :)

                    while (playerHealth > 0 && abyssHealth > 0)
                    {
                        Console.WriteLine("\n------------------------------------------------");
                        Console.WriteLine($"Your Health: {playerHealth}");
                        Console.WriteLine($"Abysswalker Health: {abyssHealth}");
                        Console.WriteLine("------------------------------------------------");

                        Console.WriteLine("Choose an action:");
                        Console.WriteLine("1. Quick Strike");
                        Console.WriteLine("2. Charge Blow");
                        Console.WriteLine("3. Raise Shield");

                        string choice = Console.ReadLine().ToLower();


                        if (choice == "1" || choice == "Quick Strike")
                        {
                            int damage = rand.Next(30, 40);

                            Console.WriteLine("\nYou slash the Abysswalker!");
                            Console.WriteLine($"You deal {damage} damage!");

                            abyssHealth -= damage;
                        }
                        else if (choice == "2" || choice == "Charge Blow")
                        {
                            int hitChance = rand.Next(0, 2);

                            if (hitChance == 1)
                            {
                                int damage = rand.Next(40, 66);

                                Console.WriteLine("\nYour heavy attack lands!");
                                Console.WriteLine($"You deal {damage} damage!");

                                abyssHealth -= damage;
                            }
                            else
                            {
                                Console.WriteLine("\nYour heavy attack misses!");
                            }
                        }
                        else if (choice == "3" || choice == "Raise Shield")
                        {
                            Console.WriteLine("\nYou brace against the freezing wind.");
                        }
                        else
                        {
                            Console.WriteLine("\nYou hesitate and lose your chance to act.");
                        }

                        if (abyssHealth <= 0)
                        {
                            break;
                        }

                        Thread.Sleep(2000);


                        int abyssAttack = rand.Next(0, 4);

                        if (abyssAttack == 0)
                        {
                            int damage = 20;

                            if (choice == "3" || choice == "Raise Shield")
                            {
                                damage /= 2;
                                Console.WriteLine("\nYou block part of the attack!");
                            }

                            Console.WriteLine("\nThe Abysswalker swings its massive blade!");
                            Console.WriteLine($"You take {damage} damage!");

                            playerHealth -= damage;
                        }
                        else if (abyssAttack == 1)
                        {
                            int damage = 35;

                            if (choice == "3" || choice == "Raise Shield")
                            {
                                damage /= 2;
                                Console.WriteLine("\nYou partially block the abyssal flames!");
                            }

                            Console.WriteLine("\nDark flames erupt across the frozen ground!");
                            Console.WriteLine($"You take {damage} damage!");

                            playerHealth -= damage;
                        }
                        else if (abyssAttack == 2)
                        {
                            Console.WriteLine("\nThe Abysswalker disappears into the blizzard...");
                            Thread.Sleep(2000);

                            Console.WriteLine("...its attack misses!");
                        }
                        else
                        {
                            int damage = 35;

                            Console.WriteLine("\nThe Abysswalker unleashes a devastating abyss strike!");
                            Console.WriteLine($"You take {damage} damage!");

                            playerHealth -= damage;
                        }

                        Thread.Sleep(2000);


                        if (abyssHealth <= 90 && abyssHealth > 0)
                        {
                            


                        }
                    }

                    if (playerHealth <= 0)
                    {
                        Death();

                        Console.WriteLine("\nYou awaken beside a lonely bonfire within the Shattered Peaks.");
                        Thread.Sleep(3000);
                    }
                    else if (abyssHealth <= 0)
                    {
                        Console.WriteLine("\nThe Abysswalker stabs its blade into the frozen ground.");
                        Thread.Sleep(3000);

                        Console.WriteLine("The entire mountain trembles violently.");
                        Thread.Sleep(3000);

                        Console.WriteLine("\nThe Abysswalker slowly falls to one knee.");
                        Thread.Sleep(3000);

                        Console.WriteLine("Black flames explode into the storm.");
                        Thread.Sleep(3500);

                        Console.WriteLine("\n\"THE ABYSS ETERNAL!\"");
                        Thread.Sleep(3500);

                        Console.WriteLine("\nThe abyssal flames begin to disappear.");
                        Thread.Sleep(3000);

                        Console.WriteLine("\n\"So the mountain... has chosen you...\"");
                        Thread.Sleep(4000);

                        Console.WriteLine("\nThe Abysswalker fades into ash within the snowstorm.");
                        Thread.Sleep(4000);

                        Console.WriteLine("\n============== VICTORY ACHIEVED ==============");
                        Thread.Sleep(4000);

                        Console.WriteLine("\nYou absorbed the Abysswalker's soul.");
                        Thread.Sleep(2500);

                        Console.WriteLine("\nYou gain +25 health.");
                        maxHealth += 25;          
                        playerHealth = maxHealth; 
                        Console.WriteLine($"Max Health:{playerHealth}");
                        Thread.Sleep(2500);
                        //Console.WriteLine("Max health increased to 200HP");
                        //Thread.Sleep(3000); CHANGE TO 150 OR 175. -Alfie

                        abysswalkerDefeated = true;
                    }
                    else
                    {
                        Console.WriteLine("You have been slain!");
                    }
                    // Boss fight end//
                }
                //Alfie. Continues towards castle
                Console.WriteLine("The snow sets on the travelers armour.");
                Thread.Sleep(2000);
                Console.WriteLine("It was now time to proceed back down the mountain");
                Thread.Sleep(2000);
                Console.WriteLine("The storm breaks, giving you a view of a large, cobblestone castle");
                Thread.Sleep(2000);
                Console.WriteLine("Waiting patiently in the distance.");
                Thread.Sleep(2000);
            }
        }
    }
}
            
