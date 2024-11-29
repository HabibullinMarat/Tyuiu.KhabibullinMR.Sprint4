using Tyuiu.KhabibullinMR.Sprint4.Task4.V4.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task4.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите количество строк");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов");
            int colomns = Convert.ToInt32(Console.ReadLine());

            int[,] mrtx = new int[rows, colomns];

            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    Console.WriteLine($"Введите {i},{j} элемент строки");
                    mrtx[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Массив:");
            for (int i = 0; i < rows;i++)
            {
                for (int j = 0;j < colomns; j++)
                {
                    Console.Write($"{mrtx[i,j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            int[,] res = ds.Calculate(mrtx);
            for (int i = 0;i < rows;i++)
            {
                for (int j = 0;j< colomns; j++)
                {
                    Console.Write($"{res[i,j]}\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
