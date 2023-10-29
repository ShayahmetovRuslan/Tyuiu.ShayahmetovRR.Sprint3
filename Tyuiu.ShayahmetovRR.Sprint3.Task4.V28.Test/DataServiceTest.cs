using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShayahmetovRR.Sprint3.Task4.V28.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task4.V28.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCalc()
		{
			DataService ds = new DataService();

			int startValue = -5;
			int endValue = 5;

			double res = ds.Calculate(startValue, endValue);

			double wait = 1.067;
			Assert.AreEqual(res, wait);
		}
	}
}
