using System.IO;
using Tyuiu.AntonovDI.Sprint5.Task5.V2.Lib;


namespace Tyuiu.AntonovDI.Sprint5.Task5.V2.Test  
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ExistsLoadFromDataFile()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask5V2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(fileExists, wait);
        }
    }
}
