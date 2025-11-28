using System.IO;
using Tyuiu.AntonovDI.Sprint5.Task7.V3.Lib;

namespace Tyuiu.AntonovDI.Sprint5.Task7.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V3.txt");
            FileInfo fileInfo = new FileInfo(path);
            bool Exists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, Exists);
        }
    }
}
