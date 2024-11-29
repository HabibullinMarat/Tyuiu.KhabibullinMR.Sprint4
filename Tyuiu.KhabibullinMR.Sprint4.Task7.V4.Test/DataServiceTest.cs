using Tyuiu.KhabibullinMR.Sprint4.Task7.V4.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task7.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            string str = "382976421897";
            int n = 3;
            int m = 4;
            int wait = 36;
            int res = ds.Calculate(n, m, str);
            Assert.AreEqual(wait, res);
        }
    }
}