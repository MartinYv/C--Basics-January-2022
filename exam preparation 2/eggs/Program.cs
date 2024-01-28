using System;

namespace eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1Eggs = int.Parse(Console.ReadLine());
            int player2Eggs = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();
         
            while (input != "End of battle")
            {
                if (input == "one")
                {
                    player2Eggs--;
                }
                if (player2Eggs <= 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {player1Eggs} eggs left.");
                    break;
                }
                if (input == "two")
                {
                    player1Eggs--;
                }
                if (player1Eggs <= 0 )
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {player2Eggs} eggs left.");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "End of battle")
            {
                Console.WriteLine($"Player one has {player1Eggs} eggs left.");
                Console.WriteLine($"Player two has {player2Eggs} eggs left.");
            }

        }
    }
}
