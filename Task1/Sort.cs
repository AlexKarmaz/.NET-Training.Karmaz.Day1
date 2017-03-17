using System;
using System.Linq;


namespace Task1
{
    /// <summary>
    /// This class contains methods that implement the merge sorting of an integer array 
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// Sorts the System.Array  
        /// </summary>
        /// <param name="arr">The one-dimensional System.Array for sorting</param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void MergeSort(int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (arr.Length == 1)
            {
                return;
            }

            int middle = arr.Length / 2;
           
            int[] arr1 = arr.Take(middle).ToArray();
            MergeSort(arr1);
            int[] arr2 = arr.Skip(middle).ToArray();
            MergeSort(arr2);

            Merge(arr,arr1,arr2);
            return; 
        }

        /// <summary>
        /// Merges two sorted arrays into one 
        /// </summary>
        /// <param name="arr">The one-dimensional System.Array for sorting</param>
        /// <param name="arr1">The first System.Array to merge</param>
        /// <param name="arr2">The second System.Array to merge</param>
        /// <exception cref="ArgumentNullException"></exception>
        private static void Merge(int[] arr,int[] arr1, int[] arr2)
        {
            if(arr1 == null || arr2 == null)
            {
                throw new ArgumentNullException();
            } 

            int a = 0, b = 0;
           
            for (int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                if (b < arr2.Length && a < arr1.Length)
                    if (arr1[a] > arr2[b])
                        arr[i] = arr2[b++];
                    else 
                        arr[i] = arr1[a++];
                else if (b < arr2.Length)
                    arr[i] = arr2[b++];
                else
                    arr[i] = arr1[a++];
            }
        }
    }
}
