using System;

namespace MagicIndex
{
    class Program
    {
        static int findMagicIndex(int[] A)
        {
 
            int mid,start,end;

            start = 0;
            end = A.Length - 1;

            while (start <= end)             
            {
                mid = (start + end) / 2;

                if (mid == A[mid])
                    return mid;

                if (mid > A[mid])
                    start = mid + 1; // check in right half of the array
                else
                    end = mid - 1;  // check in left half of the array
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] Arr = {-1, 0, 1, 2, 3, 10};

            int MI = findMagicIndex(Arr);

            if (MI == -1)
                Console.WriteLine("MagicIndex not found");
            else
                Console.WriteLine("MagicIndex Index at:" + MI);
        }
    }
}
