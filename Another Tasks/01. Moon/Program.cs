using System;

namespace _01._Moon
{
    class Program
    {
        static void Main(string[] args)
        {

            double avarageSpeed = double.Parse(Console.ReadLine());
            double litersPer100Km = double.Parse(Console.ReadLine());

            double totalDistance = 384400 * 2;
            double goAndBack = Math.Ceiling(totalDistance / avarageSpeed);
            double totalTime = goAndBack + 3;
            //Гориво = (5 * 768 800) / 100 = 38 440 литра
            double totalFuel = (litersPer100Km * totalDistance) / 100;

            Console.WriteLine($"{totalTime}");
            Console.WriteLine($"{totalFuel}");
        }
    }
}
