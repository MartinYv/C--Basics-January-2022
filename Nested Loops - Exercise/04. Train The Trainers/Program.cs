using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jury = int.Parse(Console.ReadLine());
            string input = Console.ReadLine(); //ПРЕЗЕНТАЦИЯ

            double totalPresentations = 0;
            double evalutationPresentation = 0;
            double allPresentationsEv = 0;
            
            
            while (input != "Finish")
            {
                evalutationPresentation = 0;
                for (int i = 1; i <= jury; i++)
                {
                    evalutationPresentation += double.Parse(Console.ReadLine());
                }
                    evalutationPresentation = evalutationPresentation / jury;
                    allPresentationsEv += evalutationPresentation;



                totalPresentations++;
                Console.WriteLine($"{input} - {evalutationPresentation:f2}.");


                input = Console.ReadLine();
            }
            Console.WriteLine($"Student's final assessment is {allPresentationsEv / totalPresentations:f2}.");
        }
    }
}
