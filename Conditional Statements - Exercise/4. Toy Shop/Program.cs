using System;

namespace _4._Toy_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
			//  2.Брой пъзели - цяло число в интервала[0… 1000]
			//  3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
			// 4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
			// 5.Брой миньони - цяло число в интервала[0 … 1000]
			//  6.Брой камиончета - цяло число в интервала[0 … 1000]


			double priceVacantion = double.Parse(Console.ReadLine());
			int puzzlePcs = int.Parse(Console.ReadLine());
			int dollsPcs = int.Parse(Console.ReadLine());
			int bearsPcs = int.Parse(Console.ReadLine());
			int minionsPcs = int.Parse(Console.ReadLine());
			int trucksPcs = int.Parse(Console.ReadLine());

			double toysPrice = puzzlePcs * 2.60 + dollsPcs * 3 + bearsPcs * 4.10 + minionsPcs * 8.20 + trucksPcs * 2;
			double toysCount = puzzlePcs + dollsPcs + bearsPcs + minionsPcs + trucksPcs;

			if (toysCount > 50)
			{
				toysPrice = toysPrice - toysPrice * 0.25;
			}
			toysPrice = toysPrice - toysPrice * 0.10;

			double difference = toysPrice - priceVacantion;

			if (difference >= 0)
			{
				Console.WriteLine($"Yes! {difference:F2} lv left.");
			}
			else
			{
				Console.WriteLine($"Not enough money! {Math.Abs(difference):F2} lv needed.");
			}
		}
	}
}