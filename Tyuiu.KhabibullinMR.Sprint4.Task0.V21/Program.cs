﻿using Tyuiu.KhabibullinMR.Sprint4.Task0.V21.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task0.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int[] numArray = { 8, 2, 4, 3, 8, 5, 6, 7, 9, 8 };

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < numArray.Length-1; i++)
            {
                Console.WriteLine(numArray[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Результирующий массив:");

            int res = ds.GetSumEvenArrEl(numArray);

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
