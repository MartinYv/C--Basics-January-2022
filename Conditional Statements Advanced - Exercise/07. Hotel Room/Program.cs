using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int stay = int.Parse(Console.ReadLine());
            double priceStudio = 0.0;
            double priceApartment = 0.0;
            if (month == "May" || month == "October")
            {
                priceStudio = stay * 50;

                if (stay > 14)
                {
                    priceStudio = priceStudio - priceStudio * 0.30;
                }
                else if (stay > 7)
                {
                    priceStudio = priceStudio - priceStudio * 0.05;
                }
                priceApartment = stay * 65;

                if (stay > 14)
                {
                    priceApartment = priceApartment - priceApartment * 0.10;
                }
                Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
                Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            }


            else if (month == "June" || month == "September")
            {
                priceStudio = stay * 75.20;

                if (stay > 14)
                {
                    priceStudio = priceStudio - priceStudio * 0.20;
                }

                priceApartment = stay * 68.7;

                if (stay > 14)
                {
                    priceApartment = priceApartment - priceApartment * 0.10;
                }
                Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
                Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            }

            else if (month == "July" || month == "August")
            {
                priceStudio = stay * 76;
            
               
                priceApartment = stay * 77;

                if (stay > 14)
                {
                    priceApartment = priceApartment - priceApartment * 0.10;
                }
                Console.WriteLine($"Apartment: {priceApartment:f2} lv.");
                Console.WriteLine($"Studio: {priceStudio:f2} lv.");
            }
            //Студио – 50 лв./нощувка Студио – 75.20 лв./нощувка Студио – 76 лв./нощувка    
            //Апартамент – 65 лв./нощувка Апартамент – 68.70 лв./нощувка Апартамент – 77 лв./нощувка

            // За студио, при повече от 7 нощувки през май и октомври: 5 % намаление.
            // За студио, при повече от 14 нощувки през май и октомври: 30 % намаление.
            // За студио, при повече от 14 нощувки през юни и септември: 20 % намаление.
            // За апартамент, при повече от 14 нощувки, без значение от месеца : 10 % намаление.

            // else if (month == "June" || month == "September")

            // else if (month == "July" || month == "August")


        }

    }
}
