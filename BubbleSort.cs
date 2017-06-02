using System;

namespace DataStructures
{
    public class BubbleSort
    {
        public void Sort(ref int[] A, int n)
        {

            for (int k = 1; k < n; k++)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }


            }
        }
    }
}
