using System;

namespace _02._Multiplication_Table
{
	class Program
	{
		static void Main(string[] args)
		{

			int total = 0;
			for (int i = 1; i <= 10; i++)
			{
				for (int j = 1; j <= 10; j++)
				{
					total = i * j;
					Console.WriteLine($"{i} * {j} = {total}");
				}
			}
		}
	}
}
