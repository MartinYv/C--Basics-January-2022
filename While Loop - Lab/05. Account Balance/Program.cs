using System;
using System.Threading;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //double account = 0;

            //while (input != "NoMoreMoney")
            //{
            //    double amount = double.Parse(input);

            //    if (amount < 0)
            //    {
            //        Console.WriteLine("Invalid operation!");
            //        break;
            //    }

            //    account += amount;

            //    Console.WriteLine($"Increase: {amount:f2}");

            //    input = Console.ReadLine();
            //}

            //Console.WriteLine($"Total: {account:f2}");







         ////            Напишете програма, която пресмята колко общо пари има в сметката, след като направите определен брой
         ////вноски.На всеки ред ще получавате сумата, която трябва да внесете в сметката, до получаване на команда
         ////&quot; NoMoreMoney & quot; . При всяка получена сума на конзолата трябва да се извежда &quot; Increase: &quot; +сумата и тя
         ////да се прибавя в сметката.Ако получите число по-малко от 0 на конзолата трябва да се изведе &quot; Invalid
         ////operation!&quot; и програмата да приключи. Когато програмата приключи трябва да се принтира & quot; Total:

            string input = Console.ReadLine();

            double totalSum = 0;

            while (input != "NoMoreMoney")
            {
               double amount = double.Parse(input);
                if (amount<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase: {amount:f2}");
                totalSum += amount;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {totalSum:f2}");

        }
    }
}
