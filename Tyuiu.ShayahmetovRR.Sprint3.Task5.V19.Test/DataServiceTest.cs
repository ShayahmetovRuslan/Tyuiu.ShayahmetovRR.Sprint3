using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint3.Task5.V19.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task5.V19.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();
			int x = 2;
			int startValue1 = 1;
			int startValue2 = 1;
			int endValue1 = 3;
			int endValue2 = 6;

			double res = ds.GetSumSumSeries(x, startValue1, startValue2, endValue1, endValue2);

			double wait = 30598,002;

			Assert.AreEqual(res, wait);
		}
	}
}
