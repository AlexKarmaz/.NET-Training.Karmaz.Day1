using System;


namespace Task1
{
    /// <summary>
    /// This class contains methods that implement the merge sorting of an integer array 
    /// </summary>
    public static class Sort
    {
        /// <summary>
        /// Copies a specific number of elements from an System.Array starting at the specified source index 
        /// </summary>
        /// <param name="data">The System.Array that contains the data to copy</param>
        /// <param name="index">Integer that represents the index in the data at which copying begins</param>
        /// <param name="length">Integer that represents the number of elements to copy</param>
        /// <returns>System.Array containing the copied elements</returns>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public static int[] SubArray(this int[] data, int index, int length)
        {
            if(data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }
            if(index < 0 || length < 0)
            {
                throw new ArgumentException();
            }

            int[] result = new int[length];
            Array.Copy(data, index, result, 0, length);
            return result;
        }

        /// <summary>
        /// Sorts the System.Array  
        /// </summary>
        /// <param name="arr">The one-dimensional System.Array for sorting</param>
        /// <returns> The sorted System.Array </returns>
        /// <exception cref="ArgumentNullException"></exception>
        public static int[] MergeSort(int[] arr)
        {
            if(arr == null)
            {
                throw new ArgumentNullException(nameof(arr));
            }

            if (arr.Length == 1)
            {
                return arr;
            }

            int mid_point = arr.Length / 2;
            int dif = arr.Length - mid_point;

            return Merge(MergeSort(arr.SubArray(0, mid_point)),MergeSort(arr.SubArray(mid_point,dif)));
        }

        /// <summary>
        /// Merges two sorted arrays into one 
        /// </summary>
        /// <param name="arr1">The first System.Array to merge</param>
        /// <param name="arr2">The second System.Array to merge</param>
        /// <returns> The sorted System.Array consisting of elements of two initial arrays</returns>
        /// <exception cref="ArgumentNullException"></exception>
        private static int[] Merge(int[] arr1, int[] arr2)
        {
            if(arr1 == null || arr2 == null)
            {
                throw new ArgumentNullException();
            } 

            int a = 0, b = 0;
            int[] merged = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                if (b < arr2.Length && a < arr1.Length)
                    if (arr1[a] > arr2[b])
                        merged[i] = arr2[b++];
                    else 
                        merged[i] = arr1[a++];
                else if (b < arr2.Length)
                    merged[i] = arr2[b++];
                else
                    merged[i] = arr1[a++];
            }
            return merged;
        }

    }
}
