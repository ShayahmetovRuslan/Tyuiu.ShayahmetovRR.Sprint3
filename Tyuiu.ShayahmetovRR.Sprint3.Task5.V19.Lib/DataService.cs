using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task5.V19.Lib
{
	public class DataService : ISprint3Task5V19
	{
		public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
		{
			double sum = 0;
			for (int i = startValue1; i <= stopValue1; i++)
			{
				for (int j = startValue2; j <= stopValue2; j++)
				{
					sum = sum + Math.Pow((x / Math.Cos(x)), j);
				}
			}
			return Math.Round(sum, 3);
		}
	}
}
