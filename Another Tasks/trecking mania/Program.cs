using System;

namespace trecking_mania
{
    class Program
    {
        static void Main(string[] args)
        {

            // На първия ред – броя на групите от катерачи – цяло число в интервала[1...1000]
            //          За всяка една група на отделен ред – броя на хората в групата – цяло число в интервала[1...1000]
            int groupN = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;


            for (int i = 1; i <= groupN; i++)
            {
                double n = double.Parse(Console.ReadLine());

                if (n<=5)
                {
                    p1+=n;
                }
                else if (n<=12)
                {
                    p2 += n;
                }
                else if ( n <=25)
                {
                    p3 += n;
                }
                else if (n <=40)
                {
                    p4 += n;
                }
                else if (n >= 41)
                {
                    p5 += n;
                }

            }

            //Изкачващи Мусала: 6 / 326 * 100 = 1.84%

            double totalGroup = p1 + p2 + p3 + p4 + p5;
            p1 = (p1 / totalGroup) * 100;
            p2 = (p2 / totalGroup) * 100;
            p3 = p3 / totalGroup * 100;
            p4 = p4 / totalGroup * 100;
            p5 = p5 / totalGroup * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");


        }
    }
}
