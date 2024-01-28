using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            //                                       Вход:
            //Първоначално от конзолата се прочита едно число – брой локации – цяло число в интервала[1..100]

            //За всяка една локация се четат две числа, по едно на ред:
            //1.На първия ред – очакван среден добив на ден злато – реално число в интервала[0.00..10000.00]
            //2.На втория ред – брой дни, в който ще се копае на дадената локация – цяло число в интервала[1..30]

            //За всеки ден се чете по едно число:
            //Добито злато за деня – реално число в интервала[0.00..1000.00]


            double numberLocations = double.Parse(Console.ReadLine());
          
            for (int lacations = 1; lacations <= numberLocations; lacations++)
            {
            double avarageGold = 0;
            double avarageGoldTotal =0;
                double ExpectedAvarageGoldPerDay = double.Parse(Console.ReadLine());
                double daysToDig = double.Parse(Console.ReadLine());

                for (int day = 1; day <= daysToDig; day++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    avarageGoldTotal += goldPerDay; // общо
                avarageGold = avarageGoldTotal / daysToDig; // средно
                }

                if (avarageGold >= ExpectedAvarageGoldPerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {avarageGold:f2}.");
                }
               else if (avarageGold < ExpectedAvarageGoldPerDay)
                {
                    Console.WriteLine($"You need {ExpectedAvarageGoldPerDay - avarageGold:f2} gold.");
                }
            }


        }
    }
}
    

