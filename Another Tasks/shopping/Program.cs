using System;

namespace shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //реално число- бюджет, процесори, видео, рам

            double budget = double.Parse(Console.ReadLine());
            int numVideo = int.Parse(Console.ReadLine());
            int numProcs = int.Parse(Console.ReadLine());
            int numRam = int.Parse(Console.ReadLine());


            ////Видеокарта – 250 лв./ бр.
            //// Процесор – 35 % от цената на закупените видеокарти/ бр.
            //// Рам памет – 10 % от цената на закупените видеокарти/ бр.

            double videoPrice = numVideo * 250;
           
            double procsPrice = videoPrice * 0.35;
            double procsTotal = procsPrice * numProcs;
            double ramPrice = videoPrice * 0.10;
            double ramTotal = ramPrice * numRam;


            double totalSum = videoPrice + procsTotal + ramTotal;

            if (numVideo>numProcs)
            {
                totalSum -= (totalSum * 0.15);
            }

            if (budget>=totalSum)
            {
                Console.WriteLine($"You have {budget-totalSum:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(totalSum - budget):f2} leva more!");
            }
}
    }
}
