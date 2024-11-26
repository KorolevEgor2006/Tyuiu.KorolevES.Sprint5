namespace Tyuiu.KorolevES.Sprint5.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCheckFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V22.txt");
            FileInfo file = new FileInfo(path);
            bool wait = true;
            bool res =file.Exists;
            Assert.AreEqual(wait, res);
        }
    }
}