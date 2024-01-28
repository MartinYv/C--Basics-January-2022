using System;

namespace Pastry_Shop
{
    class Program
    {
        static void Main(string[] args)
        {



            //            Торта                   Суфле            Баклава
            //  До 15 декември 24 лв./ бр.      6.66 лв./ бр.    12.60 лв./ бр.
            //След 15 декември 28.70 лв./ бр.   9.80 лв./ бр.    16.98 лв./ бр.

            //1.Сладкиш - текст - "Cake", "Souffle" или "Baklava"
            //2.Брой на поръчаните сладкиши - цяло число в интервала[1 … 10000]
            //3.Ден от месец декември преди Коледа - цяло число в интервала[1 … 24]

            string type = Console.ReadLine();
            int numberOftype = int.Parse(Console.ReadLine());
            int dayOfTheMonth = int.Parse(Console.ReadLine());
            double totalSum = 0;
            if (type == "Cake")
            {
                totalSum = numberOftype * 24;
                if (dayOfTheMonth > 15)
                {
                    totalSum = numberOftype * 28.70;
                }

                if (dayOfTheMonth <= 22)
                {
                    if (totalSum >= 100 && totalSum <= 200)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                    else if (totalSum > 200)
                    {
                        totalSum -= totalSum * 0.25;
                    }
                }
                if (dayOfTheMonth <= 15)
                {
                    totalSum -= totalSum * 0.10;
                }
                Console.WriteLine($"{totalSum:F2}");
            }

            if (type == "Souffle")
            {
                totalSum = numberOftype * 6.66;
                if (dayOfTheMonth > 15)
                {
                    totalSum = numberOftype * 9.80;
                }

                if (dayOfTheMonth <= 22)
                {
                    if (totalSum >= 100 && totalSum <= 200)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                    else if (totalSum > 200)
                    {
                        totalSum -= totalSum * 0.25;
                    }
                }
                if (dayOfTheMonth <= 15)
                {
                    totalSum -= totalSum * 0.10;
                }
                Console.WriteLine($"{totalSum:F2}");
            }

            if (type == "Baklava")
            {
                totalSum = numberOftype * 12.60;
                if (dayOfTheMonth > 15)
                {
                    totalSum = numberOftype * 16.98;
                }

                if (dayOfTheMonth <= 22)
                {
                    if (totalSum >= 100 && totalSum <= 200)
                    {
                        totalSum -= totalSum * 0.15;
                    }
                    else if (totalSum > 200)
                    {
                        totalSum -= totalSum * 0.25;
                    }
                }
                if (dayOfTheMonth <= 15)
                {
                    totalSum -= totalSum * 0.10;
                }
                Console.WriteLine($"{totalSum:F2}");
            }

            }
        }
    }
