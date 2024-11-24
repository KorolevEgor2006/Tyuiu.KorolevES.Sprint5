using Tyuiu.KorolevES.Sprint5.Task0.V10.Lib;
namespace Tyuiu.KorolevES.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Admin\AppData\Local\Temp\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}