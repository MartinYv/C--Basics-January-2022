using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double statistiNumber = double.Parse(Console.ReadLine());
            double clothPriceForStatist = double.Parse(Console.ReadLine());

            double dekoration = budget * 0.1;

            if (statistiNumber > 150)
            {
                clothPriceForStatist = clothPriceForStatist - clothPriceForStatist * 0.1;
            }

            double totalclothPrice = statistiNumber * clothPriceForStatist;

            double sum1 = dekoration + totalclothPrice;

            if (sum1 > budget)
            {
                
            }




        }
    }
}