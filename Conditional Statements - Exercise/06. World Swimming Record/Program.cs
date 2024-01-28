using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            //Рекордът в секунди – реално число в интервала [0.00 … 100000.00]
            // 2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double record = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());

            double distanceToSwim = distanceInMeters * timeInSeconds;
            double resistance = Math.Floor (distanceInMeters / 15) * 12.5;
            double totalTime = distanceToSwim + resistance;

            

            if (record <= totalTime)
            {
                Console.WriteLine($"No, he failed! He was {totalTime - record:f2} seconds slower.");
            }
            else if (record > totalTime)
                    {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

        }
    }
}
