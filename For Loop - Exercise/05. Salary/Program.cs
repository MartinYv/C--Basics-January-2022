using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSites = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            double penalty = 0;
            for (int i = 1; i <= numberOfSites; i++)
            {
                string siteName = Console.ReadLine();
                if (siteName == "Facebook")
                {
                    penalty += 150;
                }
                else if (siteName == "Instagram")
                {
                    penalty += 100;
                }
                else if (siteName == "Reddit")
                {
                    penalty += 50;
                }

                if (penalty >= salary)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }
            }
        
            
            if (penalty<salary)
                {
                    Console.WriteLine(salary - penalty);
                }
            }
        }
    }