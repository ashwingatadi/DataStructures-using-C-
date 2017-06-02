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

            /* UnComment below two lines to sort using Selection Sort */
            //SelectionSort selection_sort = new SelectionSort();
            //selection_sort.Sort(ref arr, length);

            /* UnComment below two lines to sort using Bubble Sort */
            //BubbleSort bubble_sort = new BubbleSort();
            //bubble_sort.Sort(ref arr, length);

            /* UnComment below two lines to sort using Insertion Sort */
            //InsertionSort insertion_sort = new InsertionSort();
            //insertion_sort.Sort(ref arr, length);

            Console.WriteLine(string.Join(" ", arr));
            Console.ReadLine();
        }
    }
}
