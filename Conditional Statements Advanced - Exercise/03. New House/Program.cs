using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            //Roses  Dahlias  Tulips  Narcissus  Gladiolus;
            //5        3.80    2.80      3         2.50

            //50 от 100

            double price = 0;
            if (flowers == "Roses")
            {
                price = number * 5;
                if (number > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (flowers == "Dahlias")
            {
                price = number * 3.80;

                if (number > 90)
                {
                    price = price - price * 0.15;
                }
            }

            else if (flowers == "Tulips")
            {
                price = number * 2.80;
                if (number > 80)
                {
                    price = price - price * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                price = number * 3;
                if (number < 120)
                {
                    price = price + price * 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                price = number * 2.50;
                if (number < 80)
                {
                    price = price + price * 0.20;
                }
            }

            

            if (budget>price)
            {
                Console.WriteLine($"Hey, you have a great garden with {number} {flowers} and {budget - price:f2} leva left.");
            }
            else 
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(price-budget):f2} leva more.");
            }


            
        
        }
    }
}
