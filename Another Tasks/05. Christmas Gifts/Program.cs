using System;

namespace _05._Christmas_Gifts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int age = 0;
            int kids = 0;
            int adults = 0;
            int priceToys = 0;
            int pricePoulovers = 0;


            while (input != "Christmas")
            {
                age = int.Parse(input);

                if (age<=16)
                {
                    kids++;
                    
                }
                else
                {
                    adults++;
                }
                input = Console.ReadLine();
            }

            priceToys += kids * 5;
            pricePoulovers += adults * 15;


            Console.WriteLine($"Number of adults: {adults}");
            Console.WriteLine($"Number of kids: {kids}");
            Console.WriteLine($"Money for toys: {priceToys}");
            Console.WriteLine($"Money for sweaters: {pricePoulovers}");

        }
    }
}
