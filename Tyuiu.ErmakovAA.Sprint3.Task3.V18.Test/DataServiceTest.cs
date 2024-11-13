using Newtonsoft.Json.Linq;
using Tyuiu.ErmakovAA.Sprint3.Task3.V18.Lib;
namespace Tyuiu.ErmakovAA.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VaidGetCharCount()
        {
            DataService ds = new DataService();

            string str = "4n5nvf 56 bgy";

            Assert.AreEqual("nnnnvf nn bgy", ds.ReplaceNumOnChar(str, 'n'));



        }
    }
}