using System;

namespace Cake_again
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int wight = int.Parse(Console.ReadLine());

            int size = lenght * wight;

            int pieces = 0;
            //и след това на всеки ред, до получаване на командата &quot;STOP&quot;
            //или докато не свърши тортата, броят на парчетата, които гостите вземат от нея.
            int piecesLeft = 0;
            string input = Console.ReadLine();

            while (input != "STOP")
            {                                                                           //ВЯРНА 100/100

                pieces += int.Parse(input);
                piecesLeft = size - pieces;

                if (size < pieces)
                {
                    Console.WriteLine($"No more cake left! You need {pieces - size} pieces more.");
                    break;
                }
            

                input = Console.ReadLine();
            }
            if (input == "STOP" && size > pieces)
            {
                Console.WriteLine($"{piecesLeft} pieces are left.");
               
            }
        }
    }
}
