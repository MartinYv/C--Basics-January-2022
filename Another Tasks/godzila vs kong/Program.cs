using System;

namespace godzila_vs_kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statisti = int.Parse(Console.ReadLine());
            double oblekloStatist = double.Parse(Console.ReadLine());


            double dekor = budget * 0.10;
            double oblekloCena = statisti * oblekloStatist;
            if (statisti>150)
            {
                oblekloCena -= oblekloCena * 0.10;
            }
            double totalSum = dekor + oblekloCena;


            if (budget>=totalSum)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with { budget-totalSum:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {totalSum-budget:f2} leva more.");
            }
        }
    }
}
