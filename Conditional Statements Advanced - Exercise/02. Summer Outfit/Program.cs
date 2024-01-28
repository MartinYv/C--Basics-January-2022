using System;

namespace _02._Summer_Outfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string weather = Console.ReadLine();

            string Outfit = "Sweatshirt";
            string Shoes = "Sneakers";

            //Outfit = Sweatshirt
            //Shoes = Sneakers
            if (weather == "Morning")
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
            else if (weather == "Afternoon")
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
            else if (weather == "Evening")
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



    

          