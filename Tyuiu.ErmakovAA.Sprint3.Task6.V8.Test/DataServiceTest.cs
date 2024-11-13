using Tyuiu.ErmakovAA.Sprint3.Task6.V8.Lib;
namespace Tyuiu.ErmakovAA.Sprint3.Task6.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 18; 
            int stopValue = 28;

            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 10;
            Assert.AreEqual(res, wait);
        }
    }
}