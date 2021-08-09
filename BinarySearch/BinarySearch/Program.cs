using System;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 15, 17, 23, 29, 36, 41, 50, 62, 78, 80, 99, 100 };
            int value = 62;

            Console.WriteLine(BinarySearch(arr, value));
        }

        static int BinarySearch(int[] arr, int value)
        {
            int start = 0;
            int end = arr.Length - 1;
            int indexOfValue = -1;

            while (start <= end)
            {
                int mid = (end + start) / 2;
                if (value == arr[mid])
                {
                    indexOfValue = mid;
                    return indexOfValue;
                }
                else if (value < arr[mid])
                {
                    end = mid - 1;
                }
                else if (value > arr[mid])
                {
                    start = mid + 1;
                }
            }
            return indexOfValue;
        }
    }
}
