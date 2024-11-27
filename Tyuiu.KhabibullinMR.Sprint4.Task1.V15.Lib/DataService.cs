using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhabibullinMR.Sprint4.Task1.V15.Lib
{
    public class DataService : ISprint4Task1V15
    {
        public int Calculate(int[] array)
        {
            int haha = 1;
            for (int i = 0; i < array.Length-1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    haha*=array[i];
                }
            }
            return haha;
        }
    }
}
