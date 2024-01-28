using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            // Резултатът да се закръгли до 3 цифри след десетичната запетая.
            if (figure == "square")
            {
                double size = double.Parse(Console.ReadLine());
                double area = size * size;

                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "rectangle")
            {
                double size = double.Parse(Console.ReadLine());
                double size2 = double.Parse(Console.ReadLine());

                double area = size * size2;

                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "circle")
            {
                double radius = double.Parse (Console.ReadLine());

                double area = radius * radius * Math.PI;

                Console.WriteLine($"{area:f3}");
            }
            else if (figure == "triangle")
            {
                double size = double.Parse(Console.ReadLine());
                double sizeH = double.Parse(Console.ReadLine());

                double area = size * sizeH / 2;

                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
