using System;

namespace exam_preparation
{
    class Program
    {
        static void Main(string[] args)
        {

            int problemMarks = int.Parse(Console.ReadLine());
            int failedTimes = 0;
            int numberOfTasks = 0;
            double marksSum = 0;
            string problemTask ="";


            string input = Console.ReadLine();
            while (input != "Enough")
            {
                problemTask = Console.ReadLine();
                int mark = int.Parse(Console.ReadLine());
                marksSum += mark;
                                                                                            /// под въпрос

                if (mark <= 4)
                {
                    failedTimes++;
                }
                if (failedTimes == problemMarks)
                {
                    Console.WriteLine($"You need a break, {failedTimes} poor grades.");
                    break;
                }
            
                numberOfTasks++;
                input = Console.ReadLine();
            }
            double avarageScore = numberOfTasks / marksSum;
            Console.WriteLine($"Average score: {avarageScore:f2}");
            Console.WriteLine($"Number of problems: {numberOfTasks}");
            Console.WriteLine($"Last problem: {problemTask}");
        }
    }
}
