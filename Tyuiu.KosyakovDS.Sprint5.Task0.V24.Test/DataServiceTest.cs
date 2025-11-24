using System.IO;
using Tyuiu.KosyakovDS.Sprint5.Task0.V24.Lib;

namespace Tyuiu.KosyakovDS.Sprint5.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\kosya\source\repos\Tyuiu.KosyakovDS.Sprint5\Tyuiu.KosyakovDS.Sprint5.Task0.V24\bin\Debug\net8.0\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;
            
            Assert.AreEqual(wait, fileExists);
        }
    }
}
