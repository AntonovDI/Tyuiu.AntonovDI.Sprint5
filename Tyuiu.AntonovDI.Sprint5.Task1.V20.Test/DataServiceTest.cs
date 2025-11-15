using Tyuiu.AntonovDI.Sprint5.Task1.V20.Lib;
using System.IO;

namespace Tyuiu.AntonovDI.Sprint5.Task1.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\anton\AppData\Local\Temp\OutPutFileTask1";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
