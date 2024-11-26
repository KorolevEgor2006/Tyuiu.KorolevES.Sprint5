using Tyuiu.KorolevES.Sprint5.Task5.V17.Lib;
namespace Tyuiu.KorolevES.Sprint5.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 20;
            string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";
            double res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
    }
}