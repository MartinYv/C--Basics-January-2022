using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupNum = int.Parse(Console.ReadLine());

            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            //Група до 5 човека – изкачват Мусала
            // Група от 6 до 12 човека – изкачват Монблан
            // Група от 13 до 25 човека – изкачват Килиманджаро
            // Група от 26 до 40 човека – изкачват К2
            // Група от 41 или повече човека – изкачват Еверест
            for (int i = 1; i <= groupNum; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num <= 5)
                {
                    p1 = p1 + num;
                }
                else if (num <= 12)
                {
                    p2 = p2 + num;
                }
                else if (num <= 25)
                {
                    p3 = p3 + num;
                }
                else if (num <= 40)
                {
                    p4 = p4 + num;
                }
                else
                {
                    p5 = p5 + num;
                }
            }
            double totalPeople = p1 + p2 + p3 + p4 + p5;

            p1 = p1 / totalPeople * 100;
            p2 = p2 / totalPeople * 100;
            p3 = p3 / totalPeople * 100;
            p4 = p4 / totalPeople * 100;
            p5 = p5 / totalPeople * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
