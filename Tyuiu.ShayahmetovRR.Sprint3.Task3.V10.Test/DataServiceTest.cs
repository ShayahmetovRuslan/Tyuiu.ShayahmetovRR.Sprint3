using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint3.Task3.V10.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint3.Task3.V10.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidDeleteCharInString()
		{
			DataService ds = new DataService();

			string str = "gdfppf vfppt p";
			char chr = 'p';

			var res = ds.DeleteCharInString(str, chr);
			string wait = "gdff vft ";

			Assert.AreEqual(wait, res);
		}
	}
}
