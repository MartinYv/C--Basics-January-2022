using System;

namespace vacantion
{
    class Program
    {
        static void Main(string[] args)
        {


            //Пари нужни за екскурзията -реално число в интервала[1.00...25000.00]
            // Налични пари -реално число в интервала[0.00...25000.00]
            //След това многократно се четат по два реда:
            // Вид действие – текст с възможности & quot; spend & quot; и & quot; save & quot;
            // Сумата, която ще спести / похарчи - реално число в интервала[0.01… 25000.00]

            double vacantionPrice = double.Parse(Console.ReadLine());
            double availableMoney = double.Parse(Console.ReadLine());
            double moneySaved = 0;
            double daysSpend = 0;
            double totalDays = 0;


            while (moneySaved <= vacantionPrice)
            {
                string saveOrSpend = Console.ReadLine();
                double moneySaveOrSpend = double.Parse(Console.ReadLine());
                totalDays++;

                if (saveOrSpend == "save")
                {
                    availableMoney += moneySaveOrSpend;
                    daysSpend = 0;
                    if (availableMoney >= vacantionPrice)
                    {
                        Console.WriteLine($"You saved the money for {totalDays} days.");
                        break;
                    }
                }


                if (saveOrSpend == "spend")
                {
                    daysSpend++;
                    availableMoney -= moneySaveOrSpend;

                    if (availableMoney <= 0)
                    {
                        availableMoney = 0;
                    }
                }
                if (daysSpend == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine($"{totalDays}");
                    break;
                }
            }
        }
    }


}