using Tyuiu.KorolevES.Sprint5.Task3.V15.Lib;
namespace Tyuiu.KorolevES.Sprint5.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Admin\AppData\Local\Temp\OutPutFileTask3.bin";
            FileInfo f = new FileInfo(path);
            bool wait = true;
            bool res = f.Exists;
            Assert.AreEqual(wait, res);
        }
    }
}