using tyuiu.cources.programming.interfaces.Sprint3;


namespace Tyuiu.BerezkinAA.Sprint3.Task1.V12.Lib
{
    public class DataService : ISprint3Task1V12
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;
            while (startValue <= stopValue)
            {
                sumSeries = sumSeries + Math.Pow((1 / Math.Pow(startValue, value)), 2);
                startValue += 1;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}