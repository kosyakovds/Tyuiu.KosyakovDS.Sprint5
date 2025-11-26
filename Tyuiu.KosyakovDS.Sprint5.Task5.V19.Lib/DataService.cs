using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KosyakovDS.Sprint5.Task5.V19.Lib
{
    public class DataService : ISprint5Task5V19
    {
        public double LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            string[] nums = str.Split(' ');
            List<int> integers = new List<int>();

            foreach (string num in nums)
            {
                if (int.TryParse(num.Trim(), out int number) && number >= -9 && number <= 9)
                {
                    integers.Add(number);
                }
            }

            return integers.Max() - integers.Min();
        }
    }
}
