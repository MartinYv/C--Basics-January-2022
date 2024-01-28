using System;

namespace _08._Lunch_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат 3 реда:
            // 1.Име на сериал – текст
            //2.Продължителност на епизод – цяло число в диапазона[10… 90]
            //3.Продължителност на почивката – цяло число в диапазона[10… 120]

            string serialName = (Console.ReadLine());
            int episodTime = int.Parse(Console.ReadLine());
            int breakTime = int.Parse(Console.ReadLine());

            double lunchTimeLeft = (breakTime * 1.0 / 8);
            double timeForRest =  (breakTime * 1.0 / 4);
            double timeLeft = (breakTime - lunchTimeLeft - timeForRest);

            
            
            if (episodTime <= timeLeft) 
            {
                Console.WriteLine($"You have enough time to watch {serialName} and left with {Math.Ceiling(timeLeft-episodTime)} minutes free time.");
            }
            
            else
            {
                Console.WriteLine($"You don't have enough time to watch {serialName}, you need {Math.Ceiling(episodTime-timeLeft)} more minutes.");
            }
        }
    }
}
