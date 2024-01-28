using System;

namespace _01._Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int player1Time = int.Parse(Console.ReadLine());
            int player2Time = int.Parse(Console.ReadLine());
            int player3Time = int.Parse(Console.ReadLine());

            int totalTime = player1Time + player2Time + player3Time;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");

            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }

        }
    }
}
