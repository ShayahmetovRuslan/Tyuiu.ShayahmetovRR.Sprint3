using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint3.Task4.V28.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task4.V28
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

			int startValue = -5, endValue = 5;
			char item = 'p';
			Console.WriteLine("startValue = " + startValue);
			Console.WriteLine("endValue = " + endValue);
			Console.WriteLine("y=(cos(x)+sin(x))/x");

			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Результат: " + ds.Calculate(startValue, endValue));
			Console.ReadKey();
		}
	}
}
