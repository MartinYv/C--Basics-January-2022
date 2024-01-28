using System;

namespace tennis_rank_list
{
    class Program
    {
        static void Main(string[] args)
        {

            // W - ако е победител получава 2000 точки
            // F - ако е финалист получава 1200 точки
            // SF - ако е полуфиналист получава 720 точки


            //Брой турнири, в които е участвал – цяло число в интервала[1…20]
            // Начален брой точки в ранглистата - цяло число в интервала[1...4000]
            //За всеки турнир се прочита отделен ред:
            // Достигнат етап от турнира – текст – W     F  или  SF

            int tournaments = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());

            double earnedPoint = 0;
            double wins = 0;
            for (int i = 1; i <= tournaments; i++)
            {
                string tournamentStage = Console.ReadLine();
                if (tournamentStage == "W")
                {
                    earnedPoint += 2000;
                    wins++;
                }
                else if (tournamentStage == "F")
                {
                    earnedPoint += 1200;
                }
                else
                {
                    earnedPoint += 720;
                }
            }

            //Отпечатват се три реда в следния формат:
            //Final points: { брой точки след изиграните турнири}
            //Average points: { средно колко точки печели за турнир}
            //{процент спечелени турнири}%
            //Средните точки да бъдат закръглени към най - близкото цяло число надолу    /////////      а процентът да се форматира до втората цифра след десетичния знак.
            double avarageWins = wins / tournaments * 100;

            Console.WriteLine($"Final points: {earnedPoint + startPoints}");
            Console.WriteLine($"Average points: {Math.Floor(earnedPoint/tournaments)}");
            Console.WriteLine($"{avarageWins:f2}%");  //(2 / 5) * 100 = 40 %

        }
    }
}
