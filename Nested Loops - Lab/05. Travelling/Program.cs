using System;

namespace _05._Travelling
{
	class Program
	{
		static void Main(string[] args)
		{
			string trip = Console.ReadLine();

			double savings = 0;

			while (trip != "End")
			{
				double tripPrice = double.Parse(Console.ReadLine());

				savings = 0;

				while (tripPrice > savings)
				{
					savings += double.Parse(Console.ReadLine());
				}

				Console.WriteLine($"Going to {trip}!");

				trip = Console.ReadLine();
			}
		}
	}
}
