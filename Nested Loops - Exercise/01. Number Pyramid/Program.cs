using System;

namespace _01._Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 1;


            for (int i = 1; i <= n; i++)
            {
                for (int y = 1; y <= i; y++)
                {
                    Console.Write(counter+" ");
                counter++;
                    if (counter>n)
                    {
                        break;
                    }
                }
                Console.WriteLine();
                if (counter>n)
                {
                    break;
                }
            }

                
                
                
        }
    }
}
