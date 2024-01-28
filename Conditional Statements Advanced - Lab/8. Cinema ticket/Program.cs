using System;

namespace _8._Cinema_ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();


            switch (day)
            {
                case "Monday":
                case "Thuesday":
                case "Friday":
                    Console.WriteLine(12);
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine(14);
                    break;
                default:
                    Console.WriteLine(16);
                    break;
            }
        }
    }
}
