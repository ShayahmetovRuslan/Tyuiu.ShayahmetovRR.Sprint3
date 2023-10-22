using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint3.Task0.V23.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task0.V23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #3 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #3                                                                  *");
			Console.WriteLine("* Тема: Оператор цикла for                                                   *");
			Console.WriteLine("* Задание #0                                                                 *");
			Console.WriteLine("* Вариант #23                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Написать программу используя цикл for, которая вычисляет сумму ряда по     *");
			Console.WriteLine("*                                    формуле при х = 1.5                     *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			double value = 1.5;
			int StartValue = 1;
			int StopValue = 10;

			Console.WriteLine("Переменная х = " + value);
			Console.WriteLine("StartValue = " + StartValue);
			Console.WriteLine("StopValue = " + StopValue);


			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Сумма ряда равна: " + ds.GetSumSeries(value, StartValue, StopValue));
			Console.ReadKey();
		}
	}
}
