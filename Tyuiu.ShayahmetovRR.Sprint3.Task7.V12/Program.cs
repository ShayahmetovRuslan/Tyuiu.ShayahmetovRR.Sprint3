﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint3.Task7.V12.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task7.V12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			DataService ds = new DataService();
			Console.Title = "Спринт #3 | Выполнил: Шаяхметов Р.Р | АСОиУБ-23-1";

			Console.WriteLine("**********************************************************************************");
			Console.WriteLine("* Спринт #3                                                                      *");
			Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                        *");
			Console.WriteLine("* Таск #7                                                                        *");
			Console.WriteLine("* Вариaнт #12                                                                     *");
			Console.WriteLine("* Выполнил: Шаяхметов Руслан Раилевич | АСОиУБ-23-1                           *");
			Console.WriteLine("**********************************************************************************");
			Console.WriteLine("* УСЛОВИЕ:                                                                       *");
			Console.WriteLine("* Написать программу, которая выводит таблицу значений функции                   *");
			Console.WriteLine("* Значения занести в массив.                                                     *");
			Console.WriteLine("**********************************************************************************");
			Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
			Console.WriteLine("**********************************************************************************");

			int startValue = -5;
			int stopValue = 5;

			Console.WriteLine("Старт шага = " + startValue);
			Console.WriteLine("Конец шага = " + stopValue);

			int len = ds.GetMassFunction(startValue, stopValue).Length;

			double[] arr = new double[len];

			arr = ds.GetMassFunction(startValue, stopValue);

			Console.WriteLine("**********************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
			Console.WriteLine("**********************************************************************************");

			Console.WriteLine("+----------+----------+");
			Console.WriteLine("|    X     |    f(x)  |");
			Console.WriteLine("+----------+----------+");

			for (int i = 0; i <= len - 1; i++)
			{
				Console.WriteLine("|{0,5:d}     | {1,6:f2}   |", startValue, arr[i]);
				startValue++;
			}
			Console.WriteLine("+----------+----------+");
			Console.ReadLine();
		}
	}
}
