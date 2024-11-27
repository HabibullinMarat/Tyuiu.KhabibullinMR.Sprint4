using Tyuiu.KhabibullinMR.Sprint4.Task0.V21.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task0.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] ints = new int[] { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };
            int wait = 36;
            int res = ds.GetSumEvenArrEl(ints);
            Assert.AreEqual(wait, res);
        }
    }
}