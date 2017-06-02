using System;


namespace DataStructures
{
    public class SelectionSort
    {
        public void Sort(ref int[] A, int n)
        {

            for (int i = 0; i < n - 1; i++)
            {
                int iMin = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] < A[iMin])
                    {
                        iMin = j;
                    }
                }

                int temp = A[i];
                A[i] = A[iMin];
                A[iMin] = temp;
            }
        }
    }
}
