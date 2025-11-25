using Tyuiu.KosyakovDS.Sprint5.Task2.V26.Lib;

namespace Tyuiu.KosyakovDS.Sprint5.Task2.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 2 , -3, -3 },
                                            { -8, -8, 0 },
                                            { -6, 1, 0 } };

            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }

                Console.WriteLine();
            }

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine($"Файл \n {res}");
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}