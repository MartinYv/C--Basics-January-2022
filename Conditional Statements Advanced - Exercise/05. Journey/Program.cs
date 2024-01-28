using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();


            //Бюджета определя дестинацията, а сезона определя колко от бюджета ще изхарчи.
            //Ако е лято ще почива на къмпинг
            //  а зимата в хотел.
            // Ако е в Европа, независимо от сезона ще почива в хотел.
            // Всеки къмпинг или хотел, според дестинацията, има собствена цена която отговаря на даден процент от бюджета:
            //
            //// При бюджет 100лв.или по-малко – някъде в България
            ////o Лято – 30 % от бюджета КЪМПИНГ
            ////o Зима – 70 % от бюджета ХОТЕЛ
            //// При бюджет 1000лв.или по малко – някъде на Балканите
            ////o Лято – 40 % от бюджета КЪМПИНГ
            ////o Зима – 80 % от бюджета ХОТЕЛ
            //// При повече от 1000лв. бюджет– някъде из Европа   ХОТЕЛ
            ////o При пътуване из Европа, независимо от сезона ще похарчи 90 % от бюджета.
            double vacantion = 0;
            if (budget <= 100)
            {
                if (season == "summer")
                {
                    vacantion = budget * 0.30;
                }
                else if (season == "winter")
                {
                    vacantion = budget * 0.70;
                }
            }

            if (budget <= 1000 && budget > 100)
            {
                if (season == "summer")
                {
                    vacantion = budget * 0.40;
                }
                else if (season == "winter")
                {
                    vacantion = budget * 0.80;
                }
            }

            if (budget > 1000)
            {
                vacantion = budget * 0.90;
            }



            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {vacantion:f2}");
                }

                else 
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {vacantion:f2}");
                }
            }

            if (budget <= 1000 && budget > 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {vacantion:f2}");
                }


                else
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {vacantion:f2}");
                }
            }
            if(budget>1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {vacantion:f2}");
            }

        }
        }
    }

