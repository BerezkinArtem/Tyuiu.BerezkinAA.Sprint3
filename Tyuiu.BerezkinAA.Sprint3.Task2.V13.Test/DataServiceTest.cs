using Tyuiu.BerezkinAA.Sprint3.Task2.V13.Lib;

namespace Tyuiu.BerezkinAA.Sprint3.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumseries()
        {
            DataService ds = new DataService();

            double value = 0.7;
            int startValue = 1;
            int stopValue = 10;

            double res = ds.GetSumSeries(value, startValue, stopValue);
            double wait = 4.063;

            Assert.AreEqual(res, wait);
        }
    }
}