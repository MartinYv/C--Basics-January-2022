using System;

namespace fisherman_boat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Бюджет на групата – цяло число в интервала[1…8000]
            // Сезон – текст: &quot; Spring & quot;, &quot; Summer & quot;, &quot; Autumn & quot;, &quot; Winter & quot;
            // Брой рибари – цяло число в интервала[4…18]

            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double fishermans = double.Parse(Console.ReadLine());
            
            
            
            double rent = 3000;

            if (season == "Spring")
            {
                rent = 3000;
            }
            else if (season == "Summer" )
            {
                rent = 4200;
            }
            else if (season == "Autumn")
            {
                rent = 4200;
            }
            else
            {
                rent = 2600;
            }

                    ////Ако групата е до 6 човека включително – отстъпка от 10 %.
                    //// Ако групата е от 7 до 11 човека включително – отстъпка от 15 %.
                    //// Ако групата е от 12 нагоре – отстъпка от 25 %.
                    
            
            if (fishermans<= 6)
            {
                rent -= rent * 0.10;
            }
            else if (fishermans> 7 && fishermans <= 11)
            {
                rent -= rent * 0.15;
            }
            else
            {
                rent -= rent * 0.25;
            }

            if (fishermans % 2 == 0 && season != "Autumn")
            {
                rent -= rent * 0.05;
            }

            if (budget>rent)
            {
                Console.WriteLine($"Yes! You have {budget - rent:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {rent - budget:f2} leva.");
            }
        }
    }
}
