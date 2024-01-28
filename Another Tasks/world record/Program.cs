using System;

namespace world_record
{
    class Program
    {
        static void Main(string[] args)
        {


            ////1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
            ////2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
            ////3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]

            double recordInSecs = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecs = double.Parse(Console.ReadLine());

            double distance = distanceInMeters * timeInSecs;
            double resistance = Math.Floor (distanceInMeters / 15) * 12.5;
            double totalTime = distance + resistance;

            if (totalTime<recordInSecs)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {Math.Abs(totalTime):f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(recordInSecs-totalTime):f2} seconds slower.");
            }
        }
    }
}
