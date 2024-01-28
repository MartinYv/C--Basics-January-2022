using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            //Възрастта на Лили - цяло число в интервала [1...77]
            //// Цената на пералнята - число в интервала[1.00...10 000.00]
            //// Единична цена на играчка -цяло число в интервала[0...40]
            ///
            int years = int.Parse(Console.ReadLine());
            double priceMachine = double.Parse(Console.ReadLine());
            int priceToys = int.Parse(Console.ReadLine());

            double money = 0;

            for (int i = 1; i <= years; i++)
            {
                if (i % 2==0)
                {
                    money += i * 5 - 1;
                }
                else
                {
                    money += priceToys;
                }
            }
            if(money>=priceMachine)
            {
                Console.WriteLine($"Yes! {money - priceMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {priceMachine - money:f2}");
            }
        }
    }
}
