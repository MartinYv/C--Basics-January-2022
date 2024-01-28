using System;

namespace _04._Sequence_2k_1
{
    class Program
    {
        static void Main(string[] args)
        {


            //Напишете програма, която чете число n, въведено от потребителя, и отпечатва всички числа ≤ n от редицата:
            //1, 3, 7, 15, 31, …. Всяко следващо число се изчислява като умножим предишното с 2 и добавим 1.


            int num = int.Parse(Console.ReadLine());
            int k = 1;

            while (k<=num)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
