using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint3.Task2.V15.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task2.V15.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();

			double value = 0.5;
			int StartValue = 1;
			int StopValue = 20;

			double res = ds.GetSumSeries(value, StartValue, StopValue);

			double wait = 0.298;

			Assert.AreEqual(res, wait);
		}
	}
}
