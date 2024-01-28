using System;

namespace cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int wide = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int pieces = wide * hight;
            int piecesLeft = 0;

            string input = Console.ReadLine();
            while (input != "STOP")
            {
                piecesLeft += int.Parse(input);
                if (piecesLeft>pieces)
                {
                    Console.WriteLine($"No more cake left! You need {piecesLeft-pieces} pieces more.");
                   break;
                }

                input = Console.ReadLine();
            }
            if (input == "STOP")
            {
                if (pieces>piecesLeft)
                {
                    Console.WriteLine($"{pieces - piecesLeft} pieces are left.");
                }
            }
        }
    }
}
