using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SortingAlgorithms
    {
        public void SelectionSort(ref int[] A, int n) {

            for (int i = 0; i < n - 1; i++) {
                int iMin = i;

                for (int j = i + 1; j < n; j++) {
                    if (A[j] < A[iMin]) {
                        iMin = j;
                    }
                }

                int temp = A[i];
                A[i] = A[iMin];
                A[iMin] = temp;
            }

            //return A;
        }

        public void BubbleSort(ref int[] A, int n)
        {

            for (int k = 1; k < n; k++)
            {
                for (int i=0; i < n-1; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i+1];
                        A[i+1] = temp;
                    }
                }

                
            }

            //return A;
        }

        public void InsertionSort(ref int[] A, int n) {
            for (int i = 1; i < n; i++) {
                int value = A[i];
                int hole = i;
                while (hole > 0 && A[hole - 1] > value) {
                    A[hole] = A[hole - 1];
                    hole = hole - 1;
                }
                A[hole] = value;
            }
        }
    }
}
