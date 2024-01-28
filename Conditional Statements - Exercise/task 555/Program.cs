using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {


            // 3 входа: бюджет, брой статисти, цена на облекло на статист
            double budget = double.Parse(Console.ReadLine());
            int countPerson = int.Parse(Console.ReadLine());
            double dressesForPerson = double.Parse(Console.ReadLine());

            // известна е цената за декор: 10% от бюджета
            double decoration = budget * 0.10;

            // АКО статистите са повече от 150, има отстъпка от 10% за облекло
            if (countPerson > 150)
            {
                dressesForPerson = dressesForPerson - dressesForPerson * 0.10;
            }
            double priceForDresses = countPerson * dressesForPerson;
            double totalSum = priceForDresses + decoration;
            double difference = budget - totalSum;
            //изход: Ако парите за декора и дрехите са повече от бюджета
            //изход: Ако парите за декора и дрехите са по малко или равни на бюджета:

            if (totalSum>budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(difference):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {difference:f2} leva left.");
            }
        }
    }
}

