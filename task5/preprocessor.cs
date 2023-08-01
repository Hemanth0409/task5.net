#define bubblesort
#define quicksort
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class preprocessor
    {
        #region sort

#if bubblesort
#warning this is bubble sort
        public static void bubblesort()
        {
            Console.Write("BubbleSort:");
            Console.WriteLine("\n");

            Console.Write("Number of Elements:");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[x];
            int temp;
            for (int i = 0; i < x; i++)
            {

                arr[i] = Convert.ToInt32(Console.ReadLine());


            }

            for (int i = 0; i < x - 1; i++)
            {
                for (int j = 0; j < x - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            Console.WriteLine("The sorted array elements are: ");
            foreach (int i in arr)
            {
                Console.Write(i);
                Console.WriteLine("\t");
            }
           
        }
#elif quicksort
#error this is quicksort
#line 1 "preproessor.cs"

        static public int Partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left] < pivot)
                {
                    left++;
                }
                while (arr[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
        static public void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = Partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }
#endif

        #endregion


        static void Main(string[] args)
        {

            bubblesort();
            Console.ReadLine();
            int[] arr = { 67, 12, 95, 56, 85, 1, 100, 23, 60, 9 };
            int n = 10, i;
            Console.WriteLine("Quick Sort");
            Console.Write("Initial array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            quickSort(arr, 0, 9);
            Console.Write("Sorted Array is: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}

