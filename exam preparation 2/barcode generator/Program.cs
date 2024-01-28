using System;

namespace barcode_generator
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1234
            //int d1 =num / 1000; //=> (1)
            //int d2 =num / 100 % 10; //=> (2)
            //int d3 =num / 10 % 10;//=> (3)
            //int d4 =num % 10; //=> Взимаме 4ти символ (4)
                                                                                  //2345
                                                                                 // 6789
            //if (d4 % 2 == 0)

            int startN = int.Parse(Console.ReadLine());
            int endN = int.Parse(Console.ReadLine());

            for (int a = startN / 1000; a <= endN / 1000; a++)
            {
                if (a % 2 == 0)
                {
                    continue;
                }
                for (int b = startN / 100 % 10; b <= endN / 100 % 10; b++)
                {
                    if (b % 2 == 0)
                    {
                        continue;
                    }
                    for (int c = startN / 10 % 10; c <= endN / 10 % 10; c++)
                    {
                        if (c % 2 == 0)
                        {
                            continue;
                        }
                        for (int d = startN % 10; d <= endN % 10; d++)
                        {
                            if (d % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{a}{b}{c}{d} ");
                        }
                    }
                }
            }
        }
    }
}
