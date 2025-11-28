using System.IO;
using Tyuiu.AntonovDI.Sprint5.Task6.V9.Lib;

namespace Tyuiu.AntonovDI.Sprint5.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask6V9.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);

        }
    }
}
