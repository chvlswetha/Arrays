using System;

namespace NRotation
{
    class Program
    {
        static int ElementinRotation(int[] a, int x)
        {

            int mid,start,end;
            start = 0;
            end = a.Length - 1;

            while (start <= end)
            {

                mid = (start + end) / 2;

                if (a[mid] == x)
                    return mid;

                if (a[start] < a[mid])    //left sorted
                {
                    if (a[start] <= x && x <= a[mid])  //check if element in the left
                        end = mid - 1;
                    else
                        start = mid + 1;
                }
                else   // right sorted
                {
                    if ( a[mid] <= x &&  x <= a[end])  //check if element in the right
                        start = mid + 1;
                    else
                        end = mid - 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] A = {50,60,10,20, 30, 40};
            int x = 80;
            int retval = ElementinRotation(A, x);
            if (retval != -1)
                Console.WriteLine("element:" + A[retval]+"found at Index:" + retval );
            else
                Console.WriteLine("element not found in array");
        }
    }
}
