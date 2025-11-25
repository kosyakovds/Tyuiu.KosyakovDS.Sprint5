using Tyuiu.KosyakovDS.Sprint5.Task3.V2.Lib;

namespace Tyuiu.KosyakovDS.Sprint5.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;

            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine($"x = {x}");

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            string res = ds.SaveToFileTextData(x);

            Console.WriteLine($"Файл \n {res}");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}