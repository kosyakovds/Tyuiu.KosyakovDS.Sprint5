using Tyuiu.KosyakovDS.Sprint5.Task1.V3.Lib;

namespace Tyuiu.KosyakovDS.Sprint5.Task1.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine($"startValue = {startValue}");
            Console.WriteLine($"stopValue = {stopValue}");

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine($"Файл \n {res}");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}