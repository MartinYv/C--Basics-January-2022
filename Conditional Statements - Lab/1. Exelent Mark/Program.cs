using System;

namespace _1._Exelent_Mark
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Първата задача от тази тема е да се напише конзолна програма, която чете оценка(дробно число), въведена
            //  от потребителя и отпечатва & quot; Excellent! & quot;, ако оценката е 5.50 или по-висока.


            double mark = double.Parse(Console.ReadLine());

            {
                if (mark >= 5.50) 
                    Console.WriteLine("Excellent!");
            }


        }
    }
}
