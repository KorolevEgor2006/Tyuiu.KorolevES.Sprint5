using Tyuiu.KorolevES.Sprint5.Task6.V20.Lib;
namespace Tyuiu.KorolevES.Sprint5.Task6.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalc()
        {
            DataService ds = new DataService();
            int wait = 2;
            string path = @"C:\DataSprint5\InPutDataFileTask6V20.txt";
            int res = ds.LoadFromDataFile(path);
            Assert.AreEqual(wait, res);
        }
        [TestMethod]
        public void TestCheckFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V20.txt";
            FileInfo f = new FileInfo(path);
            bool wait = true;
            bool res = f.Exists;
            Assert.AreEqual(wait, res);
        }
    }
}