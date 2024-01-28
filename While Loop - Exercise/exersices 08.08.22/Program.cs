using System;

namespace exersices_08._08._22
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int counter =0;
            string input = Console.ReadLine();
            while (input != "No More Books")
            {

                if (input == book)
                {

                    Console.WriteLine($"You checked {counter} books and found it.");
                    break;
                }
                counter++;
                input = Console.ReadLine();
            }
            if (input == "No More Books")
            
            
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {counter} books.");
                }


            }

                }
    }

