using Tyuiu.KhabibullinMR.Sprint4.Task2.V16.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[] numsArray = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int wait = 35;
            int res = ds.Calculate(numsArray);
            Assert.AreEqual(wait, res);
        }
    }
}