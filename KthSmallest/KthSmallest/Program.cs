using System;

namespace KthSmallest
{
    class Program
    {

         //Given an array and a number k where k is smaller than size of array,
         //we need to find the k’th smallest element in the given array.
         //It is given that all array elements are distinct
        static void Main(string[] args)
        {
            int[] arr = { 15,12, 4, 3, 6, 9, 5 };
                              //{3, 4, 5, 6, 8, 12, 15}

            int k = 7;

            Array.Sort(arr);  //O(nlogn)

            Console.WriteLine("Kth's  smallest number:" + arr[k - 1]);  //O(1)
        }
    }
}
