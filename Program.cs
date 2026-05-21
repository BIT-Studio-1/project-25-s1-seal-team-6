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

        //Klae's Work
        public static void Welcome()
        {
            Console.WriteLine("               __        __   _                            _                           \r\n               \\ \\      / /__| | ___ ___  _ __ ___   ___  | |_ ___                     \r\n                \\ \\ /\\ / / _ \\ |/ __/ _ \\| '_ ` _ \\ / _ \\ | __/ _ \\                    \r\n                 \\ V  V /  __/ | (_| (_) | | | | | |  __/ | || (_) |                   \r\n  _   _           \\_/\\_/ \\___|_|\\___\\___/|_| |_| |_|\\___|  \\__\\___/  _                 \r\n | |_| |__   ___  |  ___|_ _| | | ___ _ __   | |/ (_)_ __   __ _  __| | ___  _ __ ___  \r\n | __| '_ \\ / _ \\ | |_ / _` | | |/ _ \\ '_ \\  | ' /| | '_ \\ / _` |/ _` |/ _ \\| '_ ` _ \\ \r\n | |_| | | |  __/ |  _| (_| | | |  __/ | | | | . \\| | | | | (_| | (_| | (_) | | | | | |\r\n  \\__|_| |_|\\___| |_|  \\__,_|_|_|\\___|_| |_| |_|\\_\\_|_| |_|\\__, |\\__,_|\\___/|_| |_| |_|\r\n                                                           |___/                       ");
            Console.Write("\nPress Enter to start"); Console.ReadLine();
        }
        public static void Death()
        {
            Console.WriteLine("    __   __            _                       _____     _ _          _ _ _ _      \r\n    \\ \\ / /__  _   _  | |__   __ ___   _____  |  ___|_ _(_) | ___  __| | | | |     \r\n     \\ V / _ \\| | | | | '_ \\ / _` \\ \\ / / _ \\ | |_ / _` | | |/ _ \\/ _` | | | |     \r\n      | | (_) | |_| | | | | | (_| |\\ V /  __/ |  _| (_| | | |  __/ (_| |_|_|_|     \r\n  ____|_|\\___/ \\__,_| |_| |_|\\__,_| \\_/ \\___| |_|  \\__,_|_|_|\\___|\\__,_(_|_|_)   _ \r\n |  _ \\  ___  __ _| |_| |__     __ ___      ____ _(_) |_ ___   _   _  ___  _   _| |\r\n | | | |/ _ \\/ _` | __| '_ \\   / _` \\ \\ /\\ / / _` | | __/ __| | | | |/ _ \\| | | | |\r\n | |_| |  __/ (_| | |_| | | | | (_| |\\ V  V / (_| | | |_\\__ \\ | |_| | (_) | |_| |_|\r\n |____/ \\___|\\__,_|\\__|_| |_|  \\__,_| \\_/\\_/ \\__,_|_|\\__|___/  \\__, |\\___/ \\__,_(_)\r\n                                                               |___/               ");
        }

        public static void Meadow()
        {
            Console.WriteLine("        ______\r\n       /     /\\\r\n      /     /  \\\r\n     /_____/----\\_    (  \r\n    \"     \"          ).  \r\n   _ ___          o (:') o   \r\n  (@))_))        o ~/~~\\~ o   \r\n                  o  o  o\r\n");
        }

        public static void Pending_Bonfire()
        {
            Console.WriteLine("=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n==============================================*#%*===========================================\r\n============================================*@@@@============================================\r\n===========================================@@##@+============================================\r\n==========================================@@###@=============================================\r\n=========================================*@####@%============================================\r\n====================================*#===@%#####@*===========================================\r\n===================================@@@===@######%@+==========================================\r\n==================================*@@%===@########@+=========================================\r\n==================================+@%@===@%#######%@*==**+===================================\r\n===================================+**===*@########%@+=+@@@*=================================\r\n=====================================+*===@###**####%@==*@%@+================================\r\n===================================*@@%===@%###**####@*==@#@+================================\r\n==================================#@#@====@%####**###%@==@@@=================================\r\n=================================+@##@====@#####**####@=*@*==================================\r\n=================================*@##@@++@@#####***##%@====+=================================\r\n=================================+@###%@@%######***##@*=+@@@=================================\r\n==================================@%###########****##@+=@%@#=================================\r\n===============================*+=*@###########****##@==@#%@+================================\r\n===============================@@==@%###*####*****###@+*@##%@*===============================\r\n==============================*@@#=@@###**##******####@@#####@@==============================\r\n=============================@@#@#+@###***#*******############%@+============================\r\n============================@@##%@@%#*****#*******##*#####**###%@============================\r\n===========================*@#######******************###****###@*===========================\r\n========================+**@@####**#******************##*****###@%****=======================\r\n======================*@@@#@@###*****************************###@%%@@@@+++++=================\r\n==================+**#@@@%*#@###*************************+***###@#*#@@@@%@@@@@*==============\r\n==============#@@@@@#%@@@@#*@@##*******+******++*******++***###@%**%@@#***%@@@@#=============\r\n============+@@@@@@****%@@@@@@@%#****#@@@@%@@@@@@@%@@@**@@@@%@@@@@@@@#**#@@@@@@@#+===========\r\n============%@@@@@@@@#@@@@%%%@@@@@@#@@****@@*#***@@**#@@@##%@@@%%@@@@@%@@#*%@@@@@@#==========\r\n==========*@@@@@%***%@@@@@@@@@%###@@##%*#*@%*%*%#%@@#*%#@@@%%%%@@@@@@@@@###@@@@@@@@#=========\r\n=========*@@@@@@@@%@@@@@@@@@@%%#%@@#%#*%*@@%#%*%%%%@%#*%%%@@%%@@@@@@@@###%@@@@@@@@@%=========\r\n=========%@@@@@@@@@@@@%%*#@@@@@@@@@@@%%%%@@%@@@@@@@@@%%%@@@%%##%@@@#*#%@@@@@@@@@@@@+=========\r\n=========*@@@@@@@@@@@@@@@%#@@@@%%%%#%@@@@@@@%######%@@@@%#%%%%@@%%@@@@@@@@@@@@@@@%+==========\r\n==========#@@@@@@@@@@@@@@@@@@@@@@@@@%##@@%*##%%@@@@@@@@@%@@@@@@@@@@@@@@@@@@@@@@*=============\r\n============*#@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*==============\r\n================*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@*================\r\n==================+*@@@@%*@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@%+========================\r\n===========================+#@@@@@@@@#*=*@@@@@@@@@@@@@*=+**%@@%#*++==========================\r\n===============================+++++======+*#%@@@%#**========================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================\r\n=============================================================================================");
        }

<<<<<<< HEAD
        static string[] Inventory = new string[5];
=======
        public static void RespawnART()
        {
            Console.WriteLine("              _____ _                  _          ____                                      _ \r\n             |_   _(_)_ __ ___   ___  | |_ ___   |  _ \\ ___  ___ _ __   __ ___      ___ __ | |\r\n               | | | | '_ ` _ \\ / _ \\ | __/ _ \\  | |_) / _ \\/ __| '_ \\ / _` \\ \\ /\\ / / '_ \\| |\r\n               | | | | | | | | |  __/ | || (_) | |  _ <  __/\\__ \\ |_) | (_| |\\ V  V /| | | |_|\r\n               |_| |_|_| |_| |_|\\___|  \\__\\___/  |_| \\_\\___||___/ .__/ \\__,_| \\_/\\_/ |_| |_(_)\r\n                                                                |_|                           ");
            Console.ReadLine();
            Console.WriteLine("Press enter to Respawn!");
            Console.Clear();

        }
>>>>>>> 01018fd890e43aef094ae09554820321ccc68224

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
                Welcome();
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
                if (userInput.ToLower() == "y" || userInput.ToLower() == "yes")
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
                int BKhealth = 100;
                while ((playerHealth > 0) && (BKhealth > 0))
                {
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
                        }

                    }


                }


                if (playerHealth <= 0)
                {
                    Console.WriteLine("You Died...");
                    RespawnOne();
                }
                else if (BKhealth <= 0)
                {
                    Console.WriteLine("Victory Achieved");
                }
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
                userInput = Console.ReadLine();
                playerHealth = 125;
                if (userInput.ToLower() == "y" || userInput.ToLower() == "yes" || userInput.ToLower() == "proceed")
                {
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
                    Console.WriteLine("“You should not have entered this place,” a rasping voice whispers.");
                    Thread.Sleep(2000);
                    Console.WriteLine("The kneeling figure slowly rose from before the ruined altar. Beneath the hood, two pale eyes opened like dying embers in the dark.");
                    Thread.Sleep(2000);
                    int UnAssassinHealth = 115;
                    while ((playerHealth > 0) && (UnAssassinHealth > 0))
                    {
                        player = rand.Next(0, 3);
                        if (player == 0)
                        {
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("You slash the Undead Assassin with the Rusty Sword!");
                            UnAssassinHealth -= 25;
                            Console.WriteLine($"Undead Assassin Health: {UnAssassinHealth}");
                            Console.WriteLine("------------------------------------------------");
                            Thread.Sleep(2000);
                        }
                        else if (player == 1)
                        {
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("You lunge at the Undead Assassin, piercing him!");
                            UnAssassinHealth -= 50;
                            Console.WriteLine($"Undead Assassin Health: {UnAssassinHealth}");
                            Console.WriteLine("------------------------------------------------");
                            Thread.Sleep(2000);
                        }
                        else
                        {
                            Console.WriteLine("------------------------------------------------");
                            Console.WriteLine("Your sword swing misses.");
                            Console.WriteLine($"Undead Assassin Health: {UnAssassinHealth}");
                            Thread.Sleep(2000);
                            Console.WriteLine("------------------------------------------------");
                        }

                        if (UnAssassinHealth > 0)
                        {
                            int assassinAttack = rand.Next(0, 3);
                            if (assassinAttack == 0)
                            {
                                Console.WriteLine("------------------------------------------------");
                                Console.WriteLine("The Undead Assassin swings his daggers, slashing you!");
                                playerHealth -= 25;
                                Console.WriteLine($"Your Health: {playerHealth}");
                                Console.WriteLine("------------------------------------------------");
                                Thread.Sleep(2000);
                            }
                            else if (assassinAttack == 1)
                            {
                                Console.WriteLine("------------------------------------------------");
                                Console.WriteLine("The Undead Assassin darts forward, driving a dagger into your side!");
                                playerHealth -= 45;
                                Console.WriteLine($"Your Health: {playerHealth}");
                                Console.WriteLine("------------------------------------------------");
                                Thread.Sleep(2000);
                            }
                            else
                            {
                                Console.WriteLine("------------------------------------------------");
                                Console.WriteLine("The Undead Assassin's strike misses.");
                                Console.WriteLine($"Your Health: {playerHealth}");
                                Console.WriteLine("------------------------------------------------");
                                Thread.Sleep(2000);
                            }
                        }                        
                    }
                    if (playerHealth <= 0)
                    {
                        Console.WriteLine("You Died...");

                    }
                    else if (UnAssassinHealth <= 0)
                    {
                        Console.WriteLine("Victory Achieved");                        
                    }

                }
            
                else if (userInput.ToLower() == "n" || userInput.ToLower() == "no")
                {
                    Console.WriteLine("You continue onward, ignoring the cathedral..");
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

            



            //Klae's Work Section

            //if ((userInput.ToLower() == "bonfire") || (userInput.ToLower() == "campfire"))
            //    {
            //        Console.WriteLine("You arrive at a small encampment\n\n It looks like it has been left on it own, the fire only just about to go out!");
            //        Thread.Sleep(1000);
            //        Console.WriteLine("What do you do? blow on the fire or leave it to go out?");
            //        Thread.Sleep(1000);
            //        Console.WriteLine("Say Blow to keep the fire alive or say Wait to let it go out");
            //        userInput = Console.ReadLine();

            //        if (userInput.ToLower() == "blow")
            //        {
            //            Console.WriteLine("You choose to blow on it just at the right time!");
            //            Thread.Sleep(1000);
            //            Console.WriteLine("You only had just seconds before it went out");
            //            Thread.Sleep(1000);

            //            Console.WriteLine("Because you saved the bonfire it will remember to respawn you back here instead of the start");
            //            int bonfire = 0; bonfire++;
            //            Console.ReadLine();
            //        }

            //        else
            //        {
            //            Console.WriteLine("You idoit, you let it go out, the campfire will remember that!");
            //            Thread.Sleep(1000);
            //            Console.WriteLine("You lost a bonfire! you failed to save it.");
            //            Thread.Sleep(1000);
            //            Console.WriteLine("The campfire has decided to not respawn you here!");
            //            Console.ReadLine();
            //        }

            //    }


            
        }
    }
}
