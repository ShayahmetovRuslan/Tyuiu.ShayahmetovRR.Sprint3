﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint3.Task2.V15.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task2.V15
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #3 | Выполнил: Шаяхметов Р.Р | АСОиУб 23-1";
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* Спринт #3                                                                  *");
			Console.WriteLine("* Тема: Оператор цикла do...while                                            *");
			Console.WriteLine("* Задание #2                                                                 *");
			Console.WriteLine("* Вариант #15                                                                *");
			Console.WriteLine("* Выполнил: Шаяхметов Р.Р     | АСОиУб 23-1                                  *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                   *");
			Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму ряда *");
			Console.WriteLine("*                                 по формуле при х = 0.5                     *");
			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                           *");
			Console.WriteLine("******************************************************************************");

			double value = 0.5;
			int StartValue = 1;
			int StopValue = 20;

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
