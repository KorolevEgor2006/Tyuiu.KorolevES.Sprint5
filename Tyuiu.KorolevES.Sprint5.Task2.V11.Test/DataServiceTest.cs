using System.IO;
using Tyuiu.KorolevES.Sprint5.Task2.V11.Lib;

namespace Tyuiu.KorolevES.Sprint5.Task2.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[,] matrix = { { 4, 9, 3 }, { 5, 8, 8 }, { 5, 7, 5 } };
            DataService dataService = new DataService();
            string path = dataService.SaveToFileTextData(matrix);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}