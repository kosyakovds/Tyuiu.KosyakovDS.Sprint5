namespace Tyuiu.KosyakovDS.Sprint5.Task7.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\DataSprint5\OutPutDataFileTask7V21.txt";
            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists);
        }
    }
}
