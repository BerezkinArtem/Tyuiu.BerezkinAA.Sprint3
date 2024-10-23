using Tyuiu.BerezkinAA.Sprint3.Task1.V12.Lib;

namespace Tyuiu.BerezkinAA.Sprint3.Task1.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();

            int value = 5;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 1.001;

            Assert.AreEqual(res, wait);

        }
    }
}