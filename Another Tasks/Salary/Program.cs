using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Според отворения сайт в таба се налагат следните глоби:
            //Facebook 150 лв.
            // Instagram 100 лв.
            //Reddit  50 лв.
            //От конзолата се четат два реда:
            // Брой отворени табове в браузъра n -цяло число в интервала[1...10]
            // Заплата - число в интервала[500...1500]
            //След това n – на брой пъти се чете име на уебсайт – текст

            int tabs = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            for (int i = 1; i <= tabs; i++)
            {
                string site = Console.ReadLine();
                if (site == "Facebook")
                {
                    salary -= 150;
                }
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                else if (site=="Reddit")
                {
                    salary -= 50;
                }
                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
       if (salary>0)
            {
            Console.WriteLine($"{salary}");
            }
        }
    }
}
