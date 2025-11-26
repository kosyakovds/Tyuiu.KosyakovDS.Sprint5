using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosyakovDS.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string[] tokens = str.Split(' ');
            List<int> integers = new List<int>();

            foreach (string token in tokens)
            {
                if (int.TryParse(token.Trim(), out int number) && Math.Abs(number) >= 100 && Math.Abs(number) <= 1000)
                {
                    integers.Add(number);
                }
            }

            return integers.Count;
        }
    }
}
