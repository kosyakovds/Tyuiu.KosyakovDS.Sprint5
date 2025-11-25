using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosyakovDS.Sprint5.Task3.V2.Lib
{
    public class DataService : ISprint5Task3V2
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            double y = Math.Round(Math.Exp(x) / x, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;
        }
    }
}
