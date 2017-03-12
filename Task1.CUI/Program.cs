using System;
using static Task1.Sort;

namespace Task1.CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            /*Filling an array with random numbers*/
            Random rd = new Random();
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = rd.Next(-100, 100);
            }

            System.Console.WriteLine("Array before sorting:");
            foreach (int x in arr)
            {
                System.Console.Write(x + " ");
            }

            /*Sorting*/
            arr = MergeSort(arr);

            System.Console.WriteLine("");
            System.Console.WriteLine("Array after sorting:");
            foreach (int x in arr)
            {
                System.Console.Write(x + " ");
            }

        }
    }
}
