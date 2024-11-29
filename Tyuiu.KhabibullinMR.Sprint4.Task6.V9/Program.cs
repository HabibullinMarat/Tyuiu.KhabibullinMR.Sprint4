using Tyuiu.KhabibullinMR.Sprint4.Task6.V9.Lib;

namespace Tyuiu.KhabibullinMR.Sprint4.Task6.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            

            string[] mas = {"Красный", "Оранжевый", "Желтый", "Зеленый", "Синий", "Индиго", "Фиолетовый"};
            Console.WriteLine("Массив:");
            for (int i = 0; i < mas.Length; i++)
            {
                Console.WriteLine(mas[i]);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(mas);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
    
}
