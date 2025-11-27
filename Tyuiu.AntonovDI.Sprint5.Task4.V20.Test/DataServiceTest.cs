using Tyuiu.AntonovDI.Sprint5.Task4.V20.Lib;
using System.IO;

namespace Tyuiu.AntonovDI.Sprint5.Task4.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExistsLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V20.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
