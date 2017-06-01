using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            int length = arr.Length;
            SortingAlgorithms sort = new SortingAlgorithms();


            //sort.SelectionSort(ref arr, length);
            //sort.BubbleSort(ref arr, length);
            sort.InsertionSort(ref arr, length);


            Console.WriteLine(string.Join(" ", arr));
            Console.ReadLine();
        }
    }
}
