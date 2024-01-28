using System;

namespace Summer_outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string Outfit = "";
            string Shoes = "";
            if (time == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Outfit = "Sweatshirt";
                    Shoes = "Sneakers";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
            }
           else if (time == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Outfit = "T-Shirt";
                    Shoes = "Sandals";
                }
                else
                {
                    Outfit = "Swim Suit";
                    Shoes = "Barefoot";
                }
            }

            else 
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else if (degrees > 18 && degrees <= 24)
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
                else
                {
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {Outfit} and {Shoes}.");
        }

    }
}
