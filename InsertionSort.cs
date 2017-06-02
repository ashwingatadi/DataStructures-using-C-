using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class InsertionSort
    {
        public void Sort(ref int[] A, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int value = A[i];
                int hole = i;
                while (hole > 0 && A[hole - 1] > value)
                {
                    A[hole] = A[hole - 1];
                    hole = hole - 1;
                }
                A[hole] = value;
            }
        }
    }
}
