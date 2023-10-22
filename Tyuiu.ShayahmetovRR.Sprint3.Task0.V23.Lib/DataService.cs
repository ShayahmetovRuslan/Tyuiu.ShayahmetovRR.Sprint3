﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task0.V23.Lib
{
	public class DataService : ISprint3Task0V23
	{
		public double GetSumSeries(double value, int startValue, int stopValue)
		{
			double SumSeries = 0;
			int i;
			for ( i = startValue; i <= stopValue; i++)
			{
				SumSeries = SumSeries + Math.Pow(1 / (Math.Sin(i) + Math.Pow(2*value, i)), i);
			}
			return Math.Round(SumSeries, 3);
		}
	}
}
