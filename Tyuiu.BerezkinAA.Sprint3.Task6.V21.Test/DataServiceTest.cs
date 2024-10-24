using Tyuiu.BerezkinAA.Sprint3.Task6.V21.Lib;

namespace Tyuiu.BerezkinAA.Sprint3.Task6.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();
            int startValue = 19;
            int stopValue = 30;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 485;
            Assert.AreEqual(res, wait);
        }
    }
}