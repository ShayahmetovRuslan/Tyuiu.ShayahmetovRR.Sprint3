using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint3.Task5.V19.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task5.V19
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #3 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #3                                                                  *");
			Console.WriteLine("* Тема: Оператор цикла foreach                                               *");
			Console.WriteLine("* Задание #3                                                                 *");
			Console.WriteLine("* Вариант #10                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Написать программу используя цикл foreach, которая удаляет символ из строк *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			int x = 2;
			int startValue1 = 1;
			int startValue2 = 1;
			int endValue1 = 3;
			int endValue2 = 6;

			Console.WriteLine("x = " + x);
			Console.WriteLine("startValue1 = " + startValue1);
			Console.WriteLine("endValue1 = " + endValue1);
			Console.WriteLine("startValue2 = " + startValue2);
			Console.WriteLine("endValue2 = " + endValue2);

			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Результат: " + ds.GetSumSumSeries(x, startValue1, startValue2, endValue1, endValue2));
			Console.ReadKey();
		}
	}
}
