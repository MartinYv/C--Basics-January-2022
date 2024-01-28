using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());

            double dogFood = 0;
            double catFood = 0;
            double biscuits = 0;

            double totalFoodEaten = 0;
            for (int today = 1; today <= days; today++)
            {
              double  dayDogFood = double.Parse(Console.ReadLine());
              double  dayCatFood = double.Parse(Console.ReadLine());

                dogFood += dayDogFood;
                catFood += dayCatFood;
                totalFoodEaten = dogFood + catFood;
                if (today % 3 != 0)
                {
                    continue;
                }

                biscuits += (dayDogFood + dayCatFood) / 10;
            }

            Console.WriteLine($"Total eaten biscuits: {biscuits:f0}gr.");
            Console.WriteLine($"{(dogFood + catFood) * 100 / food:f2}% of the food has been eaten.");
            Console.WriteLine($"{dogFood * 100 / totalFoodEaten:f2}% eaten from the dog.");
            Console.WriteLine($"{catFood * 100 / totalFoodEaten:f2}% eaten from the cat.");
        }
    }
}