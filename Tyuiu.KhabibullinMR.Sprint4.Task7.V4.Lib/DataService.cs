﻿using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KhabibullinMR.Sprint4.Task7.V4.Lib
{
    public class DataService : ISprint4Task7V4
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] mtrx = new int[n,m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i,j] = int.Parse(value.Substring(i*m + j,1));
                }
            }

            int sum = 0;
            for (int i = 0;i < n; i++)
            {
                for (int j = 0;j < m; j++)
                {
                    if (mtrx[i,j]%2!=0)
                    {
                        sum+= mtrx[i,j];
                    }
                }
            }
            return sum;
        }
    }
}
