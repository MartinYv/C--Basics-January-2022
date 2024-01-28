using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            double seats = 0;
            double ticketNum = 0;
            double totalTickets = 0;
            double student = 0;
            double standart = 0;
            double kid = 0;

            while (movie != "Finish")
            {
                seats = int.Parse(Console.ReadLine());

                for (int i = 1; i <= seats; i++)
                {
                    string ticket = Console.ReadLine();

                    if (ticket == "End")
                    {
                        break;
                    }
                    else if (ticket == "student")
                    {
                        student++;
                    }
                    else if (ticket == "standard")
                    {
                        standart++;
                    }
                    else if (ticket == "kid")
                    {
                        kid++;
                    }

                    ticketNum++;

                }

                double percent =ticketNum / seats * 100.00;
                totalTickets += ticketNum;
                Console.WriteLine($"{movie} - {percent:f2}% full.");
                ticketNum = 0;
                movie = Console.ReadLine();

            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{student / totalTickets * 100.00:f2}% student tickets.");
            Console.WriteLine($"{standart / totalTickets * 100.00:f2}% standard tickets.");
            Console.WriteLine($"{kid / totalTickets * 100.00:f2}% kids tickets.");






        }
    }
}