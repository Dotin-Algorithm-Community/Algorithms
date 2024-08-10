using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mergeSort
{
    public class Program
    {

        public static void Mergesort(int[] arr, int low, int high)
        {
            // low = 0;
            // high = arr.Length-1;
            if (low < high)
            {
                int mid = (low + high) / 2;
                Mergesort(arr, low, mid);
                Mergesort(arr, mid + 1, high);
                Merge(arr, low, mid, high);

            }

        }

        public static void Merge(int[] arr, int low, int mid, int high)
        {
            int[] result = new int[arr.Length];
            int i = low;
            int j = mid + 1;
            int k = low;
            while (i <= mid && j <= high)
            {
                if (arr[i] < arr[j])
                {
                    result[k] = arr[i];
                    i++;

                }
                else
                {
                    result[k] = arr[j];
                    j++;
                }
                k++;

            }
            while (i <= mid)
            {
                result[k] = arr[i];
                i++;
                k++;
            }
            while (j <= high)
            {
                result[k] = arr[j];
                j++;
                k++;
            }

            // Print the merged result array
            Console.WriteLine("Merged array: " + string.Join(", ", result));

            // Copy the merged elements back to the original array
            for (i = low; i <= high; i++)
            {
                arr[i] = result[i];
            }





        }

        ///////////////////


        static void Main(string[] args)
        {
            int[] arr = { 10, 4, 6, 1, 5, 2 };
            int n = arr.Length;
            Mergesort(arr, 0, n - 1);
            Console.WriteLine("Sorted array: " + string.Join(", ", arr));

        }
    }
}
