using Tyuiu.KhabibullinMR.Sprint4.Task3.V11.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task3.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mrtx = {{8, 6, 9, 4, 5 },

                            { 9, 4, 8, 5, 6 },

                            { 9, 7, 9, 8, 4 },

                            { 4, 6, 5, 7, 8 },

                            { 6, 6, 7, 6, 4 } };

            int rows = mrtx.GetUpperBound(0) + 1;
            int columns = mrtx.Length / rows;


            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mrtx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mrtx);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
