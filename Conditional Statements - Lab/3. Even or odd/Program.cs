using System;

namespace _3._Even_or_odd
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.Write("even");
            }
            else
            {
                Console.WriteLine("odd");
            }

        }
    }
}
