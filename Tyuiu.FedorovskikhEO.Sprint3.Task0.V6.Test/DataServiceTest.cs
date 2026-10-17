using Tyuiu.FedorovskikhEO.Sprint3.Task0.V6.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 15;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 37994475.805;

            Assert.AreEqual( wait,res);
        }
    }
}
