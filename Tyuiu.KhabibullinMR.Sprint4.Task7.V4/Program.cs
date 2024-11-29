using Tyuiu.KhabibullinMR.Sprint4.Task7.V4.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task7.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int m = 4;
            int[,] mtrx = new int[n, m];

            string value = "382976421897";

            int index = 0;

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Массив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, value);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
