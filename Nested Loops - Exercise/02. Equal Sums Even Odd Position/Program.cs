using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {



            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                int even = 0;
                int odd = 0;
                string currentNum = i.ToString();
                for (int y =0 ; y < currentNum.Length; y++)
                {
                    int currentDigit = int.Parse(currentNum[y].ToString());
                    if (y % 2 == 0)
                    {
                        even += currentDigit;
                    }
                    else
                    {
                        odd += currentDigit;
                    }
                }
                if (even==odd)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
