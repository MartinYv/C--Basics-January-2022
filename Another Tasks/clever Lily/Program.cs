using System;

namespace clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {


            ////Възрастта на Лили - цяло число в интервала [1...77]
            // Цената на пералнята - число в интервала[1.00...10 000.00]
            // Единична цена на играчка -цяло число в интервала[0...40]

            int age = int.Parse(Console.ReadLine());
            double priceMachine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double moneySaved = 0;
            double toys = 0;
                    //За нечетните рождени дни(1, 3, 5...n) получава играчки.
                    // За четните рождени дни(2, 4, 6...n) получава пари.


            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySaved += i * 5 - 1;
                }
                else
                {
                    toys++;
                }
            }

            double sumToys = toys * toyPrice;
            moneySaved += sumToys;

            if (moneySaved>= priceMachine)
            {
                Console.WriteLine($"Yes! {moneySaved-priceMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceMachine - moneySaved:F2}");
            }
        }
    }
}
