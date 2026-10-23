using Tyuiu.FedorovskikhEO.Sprint3.Task4.V4.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = -35.317;

            Assert.AreEqual(wait, res);
        }
    }
}
