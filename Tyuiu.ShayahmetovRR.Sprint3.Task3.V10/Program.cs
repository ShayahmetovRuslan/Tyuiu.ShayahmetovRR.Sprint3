using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ShayahmetovRR.Sprint3.Task3.V10.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task3.V10
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

			string value = "gdfppf vfppt p";
			char item = 'p';

			Console.WriteLine("Исходная строка: " + value);
			Console.WriteLine("Удаляемый символ: " + item);

			Console.WriteLine("******************************************************************************");
			Console.WriteLine("* РЕЗУЛЬТАТ:                                                                 *");
			Console.WriteLine("******************************************************************************");

			Console.WriteLine("Итоговая строка: " + ds.DeleteCharInString(value, item));
			Console.ReadKey();
		}
	}
}
