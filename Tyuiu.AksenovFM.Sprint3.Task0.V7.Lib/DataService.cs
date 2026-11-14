using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.AksenovFM.Sprint3.Task0.V7.Lib
{
    public class DataService : ISprint3Task0V7
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double sumSeries = 0;
            double a = 0.75;

            for (int k = startValue; k <= stopValue; k++)
            {
                sumSeries += (Math.Pow(a, k) + 1) * Math.Cos(k);
            }

            return Math.Round(sumSeries, 3);
        }
    }
}