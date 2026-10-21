using Tyuiu.FedorovskikhEO.Sprint3.Task3.V11.Lib;
namespace Tyuiu.FedorovskikhEO.Sprint3.Task3.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string str = "sqwreq vqwqq q";
            string result = ds.ReplaceCharOnNum(str, 'q', '7');

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
