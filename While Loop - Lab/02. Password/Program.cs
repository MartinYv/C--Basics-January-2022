﻿using System;

namespace _02._Password
{
	class Program
	{
		static void Main(string[] args)
		{
			//Напишете програма, която първоначално прочита име и парола на потребителски профил. След това чете
			//  парола за вход.
			// при въвеждане на грешна парола: потребителя да се подкани да въведе нова парола.
			// при въвеждане на правилна парола: отпечатваме & quot; Welcome { username}

			string username = Console.ReadLine();
			string password = Console.ReadLine();


			string input = Console.ReadLine();

			while (input != password)
			{
				input = Console.ReadLine();
			}
			Console.WriteLine($"Welcome {username}!");


		}
	}
}
