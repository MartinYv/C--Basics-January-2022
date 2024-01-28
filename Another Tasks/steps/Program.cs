using System;

namespace steps
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            int steps = 0;
            while (input != "Going home")
            {
                steps += int.Parse(input);
                if (steps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{steps - 10000} steps over the goal!");
                    break;
                }
                input = Console.ReadLine();
            }
            if (input == "Going home")
            {
                input = Console.ReadLine();
                steps += int.Parse(input);
                if (steps >= 10000)
                {
                    Console.WriteLine($"Goal reached! Good job!");
                    Console.WriteLine($"{steps - 10000} steps over the goal!");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(10000 - steps)} more steps to reach goal.");
                }

            }
        }
    }
}
