using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosyakovDS.Sprint5.Task0.V24.Lib
{
    public class DataService : ISprint5Task0V24
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

            double y = (Math.Pow(x, 3) - 8) / (2 * Math.Pow(x, 2));
            double y = Math.Round(y, 3);

            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}
