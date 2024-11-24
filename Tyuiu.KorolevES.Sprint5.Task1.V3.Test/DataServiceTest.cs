using Tyuiu.KorolevES.Sprint5.Task1.V3.Lib;
namespace Tyuiu.KorolevES.Sprint5.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFileWrite()
        {
            DataService dataService = new DataService();
            string path = dataService.SaveToFileTextData(-5,5);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;sts);
            Assert.AreEqual(wait, fileExists);
        }
    }
}