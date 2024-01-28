using System;

namespace _06._Speed_Info
{
	class Program
	{
		static void Main(string[] args)
		{
			double speed = double.Parse(Console.ReadLine());
			// до 10 включително
			//   При скорост над 10 и до 50(включително) отпечатайте & quot; average & quot;
			//   При скорост над 50 и до 150(включително) отпечатайте & quot; fast & quot;
			//   При скорост над 150 и до 1000(включително) отпечатайте & quot; ultra fast&quot;
			//  При по-висока скорост отпечатайте &quot; extremely fast&quot;

			if (speed <= 10)
			{
				Console.WriteLine("slow");
			}
			if (speed > 10 && speed <= 50)
			{
				Console.WriteLine("average");
			}
			if (speed > 50 && speed <= 150)
			{
				Console.WriteLine("fast");
			}
			if (speed > 150 && speed <= 1000)
			{
				Console.WriteLine("ultra fast");
			}
			if (speed > 1000)
			{
				Console.WriteLine("extremely fast");
			}
		}

	}
}

