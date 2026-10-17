using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task0.V6.Lib
{
    public class DataService : ISprint3Task0V6
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double multiplySeries = 1;

            for (int i = startValue; i <= stopValue; i++)
            {
                multiplySeries *= 1.0 / Math.Pow(Math.Cos(5) + 1, 2);
            }

            return Math.Round(multiplySeries, 3);
        }
    }
}
