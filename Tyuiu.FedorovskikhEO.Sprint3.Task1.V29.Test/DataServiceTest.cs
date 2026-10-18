using Newtonsoft.Json.Linq;
using Tyuiu.FedorovskikhEO.Sprint3.Task1.V29.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void GetMultiplySeries()
        {
            DataService ds = new DataService();
            double value = 0.25;
            int startValue = 1;
            int stopValue = 11;

            double res = ds.GetMultiplySeries(value,  startValue,  stopValue);
            double wait = 13051.340;

            Assert.AreEqual(wait, res);
        }
    }
}
