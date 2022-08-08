using System;

namespace DiffOneSearch
{
    class Program
    {
        static int DiffOne(int[] arr, int x)
        {
            int i = 0;
            while(i < arr.Length)
            {
                if(arr[i] == x)
                {
                    return i;
                }
                i = i + Math.Abs(arr[i] - x);
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 4, 5, 4, 3, 2, 1 };
            int x = 1;
            DiffOne(arr, x);
            Console.WriteLine("Found at Index:"+ DiffOne(arr, x));
        }
    }
}
