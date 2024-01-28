using System;

namespace _04._Gifts_from_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            //От конзолата се четат точно 3 числа, всяко на отделен ред:
            // N – цяло число – 0 <= N < M
            // M – цяло число – N < M <= 10000
            // S – цяло числo – N <= S <= M    


            int n = int.Parse(Console.ReadLine());

            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            for ( int i = m; i >= n; i--)
            {

                if (i % 2 == 0 && i % 3 == 0)
                {

                    if (i == s)
                        break; ;
                Console.Write(i + " ");
                }
            }
        }
    }
    }

