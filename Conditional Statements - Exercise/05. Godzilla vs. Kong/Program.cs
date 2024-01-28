using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int broiStatisti = int.Parse(Console.ReadLine());
            double cenaOblekloNa4ovek = double.Parse(Console.ReadLine());

            
            double dekor = budget * 0.10;
            double cenaObleklo = broiStatisti * cenaOblekloNa4ovek;
            
            double moneyLeft = budget - totalSum;

            if (broiStatisti > 150)
            {
                cenaObleklo = cenaObleklo - cenaObleklo * 0.10;
                       }
            double totalSum = dekor + cenaObleklo;
            if (totalSum > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"(Wingard needs {moneyLeft:F2}  leva more.)");
            }

            if (totalSum <= budget)
            {
                Console.WriteLine("Action");
                    Console.WriteLine($"(Wingard starts filming with{moneyLeft:F2} leva left.)");
            }



        }
    }
}
