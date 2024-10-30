using Tyuiu.ErmakovAA.Sprint3.Task0.V6.Lib;
namespace Tyuiu.ErmakovAA.Sprint3.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 1;

            double res = ds.GetMultiplySeries(startValue, stopValue);
            double wait = 0.607;
            Assert.AreEqual(wait, res);
        }
    }
}