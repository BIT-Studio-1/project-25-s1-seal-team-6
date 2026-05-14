namespace NewGame
{
    internal class Program
    {
        static void Main()
        {
            string userInput;
            string result;
            Console.WriteLine("You are in a dark and forbidding place");
            Console.WriteLine("what do you want to do?");       
            userInput = Console.ReadLine();
            if (userInput == "quit")
            {
                Console.WriteLine("You quit the game");
            }
            else if (userInput == "help")
            {
                Console.WriteLine("type the following to exit the game: quit");
            }
            else
            {
                Console.WriteLine("go away");
                Thread.Sleep(1000);
            }
        }
    }
}
