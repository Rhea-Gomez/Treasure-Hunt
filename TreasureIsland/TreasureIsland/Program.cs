namespace TreasureIsland
{
    internal class Program
    {
        static void TreasureHunt()
        {
            Console.WriteLine("Choose your move: left or right?");
            string move1 = Console.ReadLine();
            if (move1 == "left")
            {
                Console.WriteLine("Choose the next move: swim or wait?");
                string move2 = Console.ReadLine();
                if (move2 == "wait")
                {
                    Console.WriteLine("Choose a colour: red or yellow or blue or anything else");
                    string move3 = Console.ReadLine();
                    if (move3 == "red")
                    {
                        Console.WriteLine("YOU ARE BURNED BY FIRE. GAME OVER!!!");
                    }
                    else if (move3 == "yellow")
                    {
                        Console.WriteLine("CONGRATULATIONS! YOU WIN!!!");
                    }
                    else if (move3 == "blue")
                    {
                        Console.WriteLine("YOU ARE EATEN BY BEAST. GAME OVER!!!");
                    }
                    else
                    {
                        Console.WriteLine("GAME OVER!");
                    }
                }
                else
                {
                    Console.WriteLine("ATTACKED BY TROUT. GAME OVER!!!");
                }
            }
            else
            {
                Console.WriteLine("FALL INTO A HOLE. GAME OVER!!!");
            }
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Treasure Island.");
            Console.WriteLine("Your mission is to find the treasure.");
            TreasureHunt();
        }
    }
}
