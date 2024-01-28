using System;

namespace _03._Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. dog -&gt; mammal
            //2.crocodile, tortoise, snake - &gt; reptile
            //3.others - &gt; unknown
            string animal = Console.ReadLine();

            switch (animal)
            {
                case ("dog"):
                    Console.WriteLine("mammal");
                    break;
                case ("crocodile"):
                case ("tortoise"):
                case ("snake"):
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
                   

            }
        }
    }
}