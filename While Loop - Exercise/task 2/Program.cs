using System;

namespace task_2
{
	class Program
	{
		static void Main(string[] args)
		{
			//Марин решава задачи от изпити докато не получи съобщение Enough от
			// лектора си. При всяка решена задача той получава оценка.Програмата трябва да приключи прочитането на
			//данни при команда & quot; Enough & quot; или ако Марин получи определения брой незадоволителни оценки.
			//Незадоволителна е всяка оценка, която е по-малка или равна на 4.
			// Ако Марин стигне до командата   Enough    отпечатайте на 3 реда:
			//Average score: { средна оценка}
			//Number of problems: { броя на всички задачи}

			//Last problem: { името на последната задача}

			// Ако получи определеният брой незадоволителни оценки:
			//You need a break, { брой незадоволителни оценки} poor grades.&quot;
			int failLimit = int.Parse(Console.ReadLine());

			double tasksNum = 0;
			double avarageScore = 0;
			string lastTask = "";
			double taskSum = 0;
			int failedTimes = 0;
			double marksSum = 0;

			string input = Console.ReadLine();
			while (input != "Enough")
			{
				lastTask = input;
				double mark = double.Parse(Console.ReadLine());
				taskSum += mark; // 

				marksSum++; // /брой оценки
				if (mark <= 4)
				{
					failedTimes++;
					if (failedTimes == failLimit)
					{
						Console.WriteLine($"You need a break, {failedTimes} poor grades.");
						break;
					}
				}
				input = Console.ReadLine();
			}
			if (failLimit != failedTimes)
			{
				avarageScore = taskSum / marksSum;
				Console.WriteLine($"Average score: {avarageScore:F2}");
				Console.WriteLine($"Number of problems: {marksSum}");
				Console.WriteLine($"Last problem: {lastTask}");
			}

		}

	}
}
