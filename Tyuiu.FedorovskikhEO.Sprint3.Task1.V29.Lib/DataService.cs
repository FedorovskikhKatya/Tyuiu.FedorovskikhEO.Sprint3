using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task1.V29.Lib
{
    public class DataService : ISprint3Task1V29
    {
        public double GetMultiplySeries(double value, int startValue, int stopValue)
        {
            double multiplySeries = 1;
            int i = startValue;

            while ( i <= stopValue)
            {
                double x = 0.25;
                multiplySeries = multiplySeries * Math.Pow(x,2) *i +2;
                i++;
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}
