﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.ShayahmetovRR.Sprint3.Task3.V10.Lib
{
	public class DataService : ISprint3Task3V10
	{
		public string DeleteCharInString(string value, char item)
		{
			foreach (char c in value)
			{
				if (c == item)
				{
					value = value.Replace(c.ToString(), String.Empty);
				}
			}
			return value;
		}
	}
}
