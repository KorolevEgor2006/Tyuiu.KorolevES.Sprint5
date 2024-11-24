using Tyuiu.KorolevES.Sprint5.Task4.V25.Lib;
namespace Tyuiu.KorolevES.Sprint5.Task4.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFileReadAndCalculate()
        {
            DataService ds = new DataService();
            double wait = 67.1;
            string path = @"C:\DataSprint5\InPutDataFileTask4V25.txt";
            double res =ds.LoadFromDataFile(path);
            Assert.AreEqual(wait,res);
        }
    }
}