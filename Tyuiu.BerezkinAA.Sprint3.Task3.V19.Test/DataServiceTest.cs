using Tyuiu.BerezkinAA.Sprint3.Task3.V19.Lib;

namespace Tyuiu.BerezkinAA.Sprint3.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceCharOnNum()
        {
            DataService ds = new DataService();

            string value = "sxxrrg x vfrx";
            char replaceable = 'x';
            char replacement = '2';

            string res = ds.ReplaceCharOnNum(value, replaceable, replacement);

            string wait = "s22rrg 2 vfr2";
            Assert.AreNotSame(res, wait);
        }
    }
}