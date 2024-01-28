using System;

namespace _04._Personal_Titles
{
	class Program
	{
		static void Main(string[] args)
		{
			double age = double.Parse(Console.ReadLine());
			string gander = (Console.ReadLine());

			// Mr. – мъж на 16 или повече години m
			//Master– момче под 16 години m
			// Ms.– жена на 16 или повече години F
			// Miss под 16 години F

			if (gander == "m")
			{
				if (age >= 16)
				{
					Console.Write("Mr.");
				}

				else
				{
					Console.WriteLine("Master");
				}
			}
			if (gander == "f")
			{
				if (age >= 16)
				{
					Console.WriteLine("Ms.");
				}
				else
				{
					Console.WriteLine("Miss");
				}
			}

		}
	}
}



