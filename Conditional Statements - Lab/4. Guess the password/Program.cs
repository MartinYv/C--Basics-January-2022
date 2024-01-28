using System;

namespace _4._Guess_the_password
{
	class Program
	{
		static void Main(string[] args)
		{
			string password = Console.ReadLine();

			if (password == "s3cr3t!P@ssw0rd")
			{
				Console.Write("Welcome");
			}
			else
			{
				Console.WriteLine("Wrong password!");
			}
		}
	}
}
