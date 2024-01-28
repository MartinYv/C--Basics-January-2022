using System;

namespace _02._Bonus_Score
{
	class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			// Ако числото е до 100 включително, бонус точките са 5.
			//  Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
			//  Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.

			double bonus = 0.0;

			if (number <= 100)
			{
				bonus = 5;
			}
			else if (number > 1000)
			{
				bonus = number * 0.10;
			}
			else
			{
				bonus = number * 0.20;
			}
			if (number % 2 == 0)
			{
				bonus = bonus + 1;
			}
			else if (number % 10 == 5)
			{
				bonus += 2;
			}

			Console.WriteLine(bonus);
			Console.WriteLine(number + bonus);
		}
	}
}
