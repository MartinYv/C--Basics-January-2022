using System;

namespace toystore
{
    class Program
    {
        static void Main(string[] args)
        {


            //Цена на екскурзията - реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearscCunt = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucsCount = int.Parse(Console.ReadLine());

            double totalToys = puzzleCount + dollsCount + bearscCunt + minionsCount + trucsCount;
            double totalPrice = puzzleCount * 2.60 + dollsCount * 3 + bearscCunt * 4.10 + minionsCount * 8.20 + trucsCount * 2;

            if (totalToys > 50)
            {
                totalPrice -= totalPrice * 0.25;
            }
            totalPrice -= totalPrice * 0.10;

            if (tripPrice < totalPrice)
            {
                Console.WriteLine($"Yes! {totalPrice - tripPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tripPrice - totalPrice:f2} lv needed.");
            }

        }
    }
}
