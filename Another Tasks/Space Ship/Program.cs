using System;

namespace Space_Ship
{
    class Program
    {
        static void Main(string[] args)
        {
            //На първия ред е широчината на кораба - реално число в интервала[1.00... 10.00]
            // На втория ред е дължината на кораба - реално число в интервала[1.00…10.00]
            // На третия ред е височината на кораба - реално число в интервала[1.00…20.00]
            // На четвъртия ред е средната височина на астронавтите -реално число в интервала[1.50 … 1.90


            double wide = double.Parse(Console.ReadLine());
            double lenght = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double avarageHightAustro = double.Parse(Console.ReadLine());


            double sizeShip = wide * lenght * hight;
            double sizeRoom = (avarageHightAustro + 0.40) * 2 * 2;

            double  austro = Math.Floor(sizeShip / sizeRoom);

            // по валък от 3,   3-10 включително,    над 10

            if (austro< 3 )
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if (austro >= 3 && austro <=10)
            {
                Console.WriteLine($"The spacecraft holds {austro} astronauts.");
            }
            else if (austro>10)
           
            {
                Console.WriteLine("The spacecraft is too big.");
            }
    }
    }
}
