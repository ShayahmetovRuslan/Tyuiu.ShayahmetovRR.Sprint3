using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint3.Task0.V23.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task0.V23.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidGetSumSeries()
		{
			DataService ds = new DataService();

			double value = 1.5;
			int StartValue = 1;
			int StopValue = 10;

			double res = ds.GetSumSeries(value, StartValue, StopValue);

			double wait = 0.271;

			Assert.AreEqual(res, wait);
		}
	}
}
