using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //бюджет, сезон, брой рибари
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            ////            Цената зависи от сезона:
            //// Цената за наем на кораба през пролетта е 3000 лв.
            //// Цената за наем на кораба през лятото и есента е 4200 лв.
            //// Цената за наем на кораба през зимата е 2600 лв.
            double rent = 3000;
            if(season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer")
            {
                rent = 4200;
            }
            else if(season == "Autumn")
            {
                rent = 4200;
            }
            else
            {
                rent = 2600;
            }


            if (fishermans <= 6)
            {
                rent = rent - rent * 0.10;
            }
             if(fishermans> 7 && fishermans <=11)
            {
                rent = rent - rent * 0.15;
            }
             if (fishermans> 12)
            {
                rent = rent - rent * 0.25;
            }

            if (fishermans % 2 == 0 && season != "Autumn")
            {
                rent = rent - rent * 0.05;
            }

            if (budget < rent)
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(rent-budget):f2} leva.");
            }
            else
            {
                Console.WriteLine($"Yes! You have {budget - rent:f2} leva left.");
            }
            ////В зависимост от броя си групата ползва отстъпка:
            //// Ако групата е до 6 човека включително – отстъпка от 10%.
            //// Ако групата е от 7 до 11 човека включително – отстъпка от 15%.
            //// Ако групата е от 12 нагоре – отстъпка от 25%.
            ////Рибарите ползват допълнително 5% отстъпка, ако са четен брой освен ако не е есен - тогава нямат
            ////допълнителна отстъпка, която се начислява след като се приспадне отстъпката по горните критерии.
            ////Напишете програма, която да пресмята дали рибарите ще съберат достатъчно пари.
        }
    }
}
