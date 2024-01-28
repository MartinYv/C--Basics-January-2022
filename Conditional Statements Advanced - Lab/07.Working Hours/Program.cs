using System;

namespace _07.Working_Hours
{
	class Program
	{
		static void Main(string[] args)
		{
			int hour = int.Parse(Console.ReadLine());
			string day = Console.ReadLine();

			if (day == "Monday")
			{
				if (hour >= 10 && hour < 18)

				{
					Console.WriteLine("open");
				}
			}
			else if (day == "Tuesday")

				if (hour >= 10 && hour < 18)
				{
					Console.WriteLine("open");
				}
				else if (day == "Wednesday")

					if (hour >= 10 && hour < 18)
					{
						Console.WriteLine("open");
					}


					else if (day == "Thursday")

						if (hour >= 10 && hour < 18)
						{
							Console.WriteLine("open");
						}

						else if (day == "Friday")

							if (hour >= 10 && hour < 18)
							{
								Console.WriteLine("open");
							}

							else if (day == "Saturday")

								if (hour >= 10 && hour < 18)
								{
									Console.WriteLine("open");
								}

								else


								{
									Console.WriteLine("closed");
								}
		}


		// if (hour > 10 && hour < 18)
		// {
		//     Console.WriteLine("open");
		// }
		// else {
		//    Console.WriteLine("closed");
		// }
	}
}








