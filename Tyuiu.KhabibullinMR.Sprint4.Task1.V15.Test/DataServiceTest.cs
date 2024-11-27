using Tyuiu.KhabibullinMR.Sprint4.Task1.V15.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] array = new int[] { 6, 7, 6, 7, 5, 7, 6, 7, 9, 4, 6, 5, 8, 5 };
            int wait = 41472;
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}