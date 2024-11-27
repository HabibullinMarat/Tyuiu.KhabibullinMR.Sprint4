using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhabibullinMR.Sprint4.Task2.V16.Lib
{
    public class DataService : ISprint4Task2V16
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            for (int i = 0; i <= array.Length-1; i++)
            {
                if (array[i] % 2 == 1)
                { sum += array[i]; }
            }
            return sum;
        }
    }
}
