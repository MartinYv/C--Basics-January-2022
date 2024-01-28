using System;

namespace _06._Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            //Напишете програма, която до получаване на командата Stop  чете цели числа, въведени от потребителя и
            //намира най-голямото измежду тях. Въвежда се по едно число на ред.

            int max = int.MinValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number > max)
                {
                    max = number;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
