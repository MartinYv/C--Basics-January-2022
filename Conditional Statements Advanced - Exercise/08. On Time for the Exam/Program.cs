using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред - дни за престой - цяло число в интервала [0...365]
            // Втори ред -вид помещение - &quot; room for one person&quot;, &quot; apartment & quot; или & quot; president apartment&quot;
            // Трети ред -оценка - &quot; positive & quot; или & quot; negative & quot;

            int stay = int.Parse(Console.ReadLine());
            string type = (Console.ReadLine());
            string mark = (Console.ReadLine());

            //&quot;room for one person&quot; – 18.00 лв за нощувка
            // &quot; apartment & quot; – 25.00 лв за нощувка
            // &quot; president apartment&quot; – 35.00 лв за нощувка
            double price = 0;
            if (type == "room for one person")
            {
                price = (stay-1) * 18;
                if (mark == "positive")
                {
                    price = price + price * 0.25;
                }
                else 
                {
                    price = price - price * 0.10;
                }
                Console.WriteLine($"{price:f2}");
            }


            if (type == "apartment")
            {
                price = (stay - 1) * 25;
                if (stay < 10)
                {
                    price = price - price * 0.30;
                }
                else if (stay > 10 && stay < 15)
                {
                    price = price - price * 0.35;
                }
                else if (stay > 15)
                {
                    price = price - price * 0.50;
                }
                if (mark == "positive")
                {
                    price = price + price * 0.25;
                }
                else 
                {
                    price = price - price * 0.10;
                }
                Console.WriteLine($"{price:f2}");
            }


            if (type == "president apartment")
            {
                price = (stay - 1) * 35;
                if (stay < 10)
                {
                    price = price - price * 0.10;
                }
                else if (stay > 10 && stay < 15)
                {
                    price = price - price * 0.15;
                }
                else if (stay > 15)
                {
                    price = price - price * 0.20;
                }
                if (mark =="positive")
                {
                    price = price + price * 0.25;
                }
                else 
                {
                    price = price - price * 0.10;
                }
                Console.WriteLine($"{price:f2}");
            }



            //if (mark == "negative")

        }
    }
}
