using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //            От конзолата се четат:
            // Пари нужни за екскурзията -реално число в интервала[1.00...25000.00]
            // Налични пари -реално число в интервала[0.00...25000.00]
            //След това многократно се четат по два реда:
            // Вид действие – текст с възможности & quot; spend & quot; и & quot; save & quot;
            // Сумата, която ще спести / похарчи - реално число в интервала[0.01… 25000.00]

            double tripPrice = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            string input = ""; // save / spend
            double spendDays = 0; // дни в които харчи
            double daysCount = 0; // изминали дни
            double money = 0;

            while (availableMoney<tripPrice)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                daysCount++;
                if (input == "save")
                {
                    availableMoney += money;
                    spendDays = 0;
                }
                else
                {
                    availableMoney -= money;
                }
                if (availableMoney<0)
                {
                    availableMoney = 0;
                }
                spendDays++;
                if (spendDays == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine($"{daysCount}");
                    break;
                }
            }
        
 
            if (availableMoney >= tripPrice)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
}
    }
}