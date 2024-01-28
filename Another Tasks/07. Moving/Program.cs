using System;

namespace _07._Moving
{
    class Program
    {
        static void Main(string[] args)
        {



            //1.Широчина на свободното пространство - цяло число в интервала[1...1000]
            //2.Дължина на свободното пространство - цяло число в интервала[1...1000]
            //3.Височина на свободното пространство - цяло число в интервала[1...1000]
            //4.На следващите редове(до получаване на команда  Done ) -брой кашони, които се пренасят в
            //квартирата - цяло число в интервала[1...10000]
            //Програмата трябва да приключи прочитането на данни при команда Done или ако свободното място
            //свърши.

            int wideFC = int.Parse(Console.ReadLine());
            int lenghtFC = int.Parse(Console.ReadLine());
            int hightFC = int.Parse(Console.ReadLine());

            int availableSpace = wideFC * lenghtFC * hightFC;
            int spaceTaken = 0;
            string input = Console.ReadLine();

            while (input != "Done")
            {
                spaceTaken += int.Parse(input);
                if (spaceTaken > availableSpace)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(spaceTaken - availableSpace)} Cubic meters more.");
                    break;
                }
            input = Console.ReadLine();
            }
        
         if (input=="Done")
                {
                if (spaceTaken < availableSpace)
                {
                    Console.WriteLine($"{availableSpace - spaceTaken} Cubic meters left.");
                }
                    }
}
    }
}
