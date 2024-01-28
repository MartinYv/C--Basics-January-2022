using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {

            //            Име на актьора - текст
            //• Точки от академията - реално число в интервала[2.0... 450.5]
            //• Брой оценяващи n - цяло число в интервала[1… 20]

            //На следващите n - на брой реда:
            //o Име на оценяващия -текст
            //o Точки от оценяващия -реално число в интервала[1.0... 50.0]

            string actorsName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int jury = int.Parse(Console.ReadLine());
            //Точките, които актьора получава се формират от: дължината на името на оценяващия умножено по точките, които дава делено на две.

            for (int i = 1; i <= jury; i++)
            {
                string juryName = Console.ReadLine();
                double juryPoints = double.Parse(Console.ReadLine());

               academyPoints += juryName.Length * juryPoints / 2;  //+ ((11 * 45) / 2)

                //1250.5 програмата трябва да прекъсне и да се отпечата, че дадения актьор е получил номинация.
                if (academyPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }
            }

            if (academyPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {academyPoints} you need {1250.5 - academyPoints:f1} more!");
            }

        }
    }
}
