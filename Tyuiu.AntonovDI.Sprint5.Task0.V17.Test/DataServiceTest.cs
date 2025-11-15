using Tyuiu.AntonovDI.Sprint5.Task0.V17.Lib;
using System.IO;

namespace Tyuiu.AntonovDI.Sprint5.Task0.V17.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\anton\Desktop\Тиу\source\repos\Tyuiu.AntonovDI.Sprint5\Tyuiu.AntonovDI.Sprint5.Task0.V17\bin\Debug\OutPutFileTask0";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists; //Проверка сущ-ет ли файл
            bool wait = false;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
