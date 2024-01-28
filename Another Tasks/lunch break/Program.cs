using System;

namespace lunch_break
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Име на сериал – текст
            ////2.Продължителност на епизод – цяло число в диапазона[10… 90]
            ////3.Продължителност на почивката – цяло число в диапазона[10… 120]


            string serial = Console.ReadLine();
            int episodTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double timeForLunch = breakTime * 1.0 / 8;
            double timeForRest = breakTime * 1.0 / 4;
            double timeLeft = breakTime - timeForLunch - timeForRest;

            if (timeLeft>= episodTime)
            {
                Console.WriteLine($"You have enough time to watch {serial} and left with {Math.Ceiling(timeLeft - episodTime)} minutes free time.");
            }
            else
            {
                Console.Write($"You don't have enough time to watch {serial}, you need {Math.Ceiling(episodTime - timeLeft)} more minutes.");
            }

        }
    }
}
