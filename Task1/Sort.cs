using System;


namespace Task1
{
    public static class Sort
    {
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

       public static int[] Merge(int[] arr1, int[] arr2)
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
