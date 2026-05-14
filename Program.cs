namespace NewGame
{
    internal class Program
    {
        static void Main()
        {
            string userInput;
            string result;
            Console.WriteLine("You are in a dark and forbidding place");
            Console.WriteLine("What do you want to do?");       
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                Console.WriteLine("You quit the game");
                Thread.Sleep(1000);
            }
            else if (userInput == "help")
            {
                Console.WriteLine("type the following to exit the game: quit");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("go away");
                Thread.Sleep(1000);
            }
            
            Console.Clear();
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

            Console.WriteLine("\n\nWhat would you like to do?");
            Console.WriteLine("Type Help for help. This will be available all throughout the game.");
            Console.ReadLine();
        }
    }
}
