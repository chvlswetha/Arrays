using System;

namespace Subarray_Sum1
{
    class Program
    {
        static (int,int) findsum(int[] a,int x)
        {
            int sum = 0, s = 0, e = 0;
            int i = 0;
            for (i=0; i<a.Length; i++)
            {
                sum += a[i];

                while (sum > x)
                {
                    sum -= a[s];
                    s++;
                }
                if(sum == x)
                {
                    return (s, e);
                }
                e++;
            }
            if (i == a.Length || (s > e && sum == 0))
                return (-1, -1);
            else
                return (s, e);
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 4, 0, 0, 3, 10, 5 };
            int x = 0;

            var (st, en) = findsum(arr, x);

            if ((st == -1 && en == -1) || (st>en))
                Console.WriteLine("No Subarraay found");
            else
                Console.WriteLine("Sum: "+x +" :is at subarray with indexes at :" + st + ":" + en);


        }
    }
}
