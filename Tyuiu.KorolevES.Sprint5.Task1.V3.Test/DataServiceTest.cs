using Tyuiu.KorolevES.Sprint5.Task1.V3.Lib;
namespace Tyuiu.KorolevES.Sprint5.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFileWrite()
        {
            string path = @"C:\Users\Admin\AppData\Local\Temp\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}