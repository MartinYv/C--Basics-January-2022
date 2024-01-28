using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            //N видеокарти, M процесора и P на брой рам памет.
            double budget = double.Parse(Console.ReadLine());
            int Nvideo = int.Parse(Console.ReadLine());
            int pProcessors = int.Parse(Console.ReadLine());
            int NRam = int.Parse(Console.ReadLine());

            double videoPrice = Nvideo * 250;
            double processor = videoPrice * 0.35;
            double processorPrice = processor * pProcessors;
            double ramPrice = videoPrice * 0.10;
            double ramPricetotal = ramPrice * NRam;

            double totalPrice = videoPrice + processorPrice + ramPricetotal;

            if (Nvideo > pProcessors)
            {
                totalPrice = totalPrice - (totalPrice * 0.15);
            }
            
            double difference = budget - totalPrice;
            
            if (difference >= 0)
            {
                Console.WriteLine($"You have {difference:f2} leva left!");
                }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(difference):f2} leva more!");
            }

        }
    }
}

        
    

