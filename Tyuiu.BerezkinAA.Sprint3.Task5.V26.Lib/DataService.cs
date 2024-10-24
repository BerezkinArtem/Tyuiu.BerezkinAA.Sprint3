using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.BerezkinAA.Sprint3.Task5.V26.Lib
{
    public class DataService : ISprint3Task5V26
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int i, k;
            for (i = startValue1; i <= stopValue1; i++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries = sumSeries + (x + Math.Sin(k));
                }
            }
            return Math.Round(sumSeries, 3);
            
        }
    }
}
