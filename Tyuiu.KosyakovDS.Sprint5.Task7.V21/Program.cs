using Tyuiu.KosyakovDS.Sprint5.Task7.V21.Lib;

namespace Tyuiu.KosyakovDS.Sprint5.Task7.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask7V21.txt";
            string pathSaveFile = @"C:\DataSprint5\OutPutDataFileTask7V21.txt";

            Console.WriteLine($"Данные находятся в файле {path}");

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            string res = ds.LoadDataAndSave(path);
            Console.WriteLine($"Результат находится в файле: \n {res}");
            Console.ReadKey();
        }
    }
}