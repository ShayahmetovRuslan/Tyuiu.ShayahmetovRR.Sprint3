using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.ShayahmetovRR.Sprint3.Task2.V15.Lib
{
	public class DataService : ISprint3Task2V15
	{
		public double GetSumSeries(double value, int startValue, int stopValue)
		{
			double SumSeries = 0;
			int i;
			i = startValue;
			do
			{
				SumSeries = SumSeries + (Math.Pow(value, i) + 0.5) * Math.Cos(i);
				i++;
			}
			while(i <= stopValue);

			return Math.Round(SumSeries, 3);
		}
	}
}
