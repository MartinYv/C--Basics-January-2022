using System;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int wight = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int size = wight * lenght;
            string input = "";
            int piecesCounter = 0;
            int piecesLeft = 0;
            while (input != "stop" || size >= 0)
            {
                input = Console.ReadLine();
                piecesLeft = size - int.Parse(input);
                piecesCounter++;
                if (input == "stop" && size<=0)
                {
                    Console.WriteLine($"{piecesLeft} pieces are left.");
                    break;
                }
              
                
            }

        }
    }
}
