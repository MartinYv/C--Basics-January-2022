﻿using System;

namespace _05._Small_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			string product = (Console.ReadLine());
			string town = Console.ReadLine();
			double quantity = double.Parse(Console.ReadLine());


			double price = 0;
			if (town == "Sofia")

				if (product == "coffie")
				{
					price = 0.50;
				}
				else if (product == "water")
				{
					price = 0.80;
				}
				else if (product == "beer")
				{
					price = 1.20;
				}
				else if (product == "sweets")
				{
					price = 1.45;
				}
				else if (product == "peanuts")
				{
					price = 1.60;
				}


			if (town == "Plovdiv")

				if (product == "coffie")
				{
					price = 0.40;
				}
				else if (product == "water")
				{
					price = 0.70;
				}
				else if (product == "beer")
				{
					price = 1.15;
				}
				else if (product == "sweets")
				{
					price = 1.30;
				}
				else if (product == "peanuts")
				{
					price = 1.50;
				}


			if (town == "Varna")

				if (product == "coffie")
				{
					price = 0.45;
				}
				else if (product == "water")
				{
					price = 0.70;
				}
				else if (product == "beer")
				{
					price = 1.10;
				}
				else if (product == "sweets")
				{
					price = 1.35;
				}
				else if (product == "peanuts")
				{
					price = 1.55;
				}

			double total = price * quantity;
			Console.WriteLine(total);




			// = 0.50;
			// water = 0.80;
			// beer = 1.20;
			//sweets = 1.45;
			//peanuts = 1.60;

			// if (town == "Plovdiv")

			// coffie = 0.40;
			// water = 0.70;
			// beer = 1.15;
			// sweets = 1.30;
			//peanuts = 1.50;

			//else


			// coffie = 0.45;
			// water = 0.70;
			// beer = 1.10;
			//sweets = 1.35;
			// peanuts = 1.55;






		}
	}
}
