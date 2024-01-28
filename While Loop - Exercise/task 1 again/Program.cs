using System;

namespace task_1_again
{
    class Program
    {
        static void Main(string[] args)
        {

            string bookName = Console.ReadLine();
            int count = 0;
            string input = Console.ReadLine();

            while (input != "No More Books")
            {
                if (input == bookName)
                {
                    Console.WriteLine($"You checked {count} books and found it.");
                    break;
                }
                count++;
                input = Console.ReadLine();
            }
                if (input == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                      Console.WriteLine($" You checked {count} books.");
                }
                
            

            
            
            
            ////Ако не открие търсената книгата да се отпечата на два реда:
                ////The book you search is not here! You checked { брой} books.
                //// Ако открие книгата си се отпечатва един ред:
                //// You checked { брой} books and found it.
        }
    }
}
