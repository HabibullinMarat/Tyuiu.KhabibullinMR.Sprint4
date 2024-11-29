using Tyuiu.KhabibullinMR.Sprint4.Task5.V4.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task5.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas = { { -4, 5 - 3 }, { 4, 5 - 2 }, { 4, 5 - 1 } };
            int wait = 5;
            int res = ds.Calculate(mas);
            Assert.AreEqual(wait, res);
        }
    }
}