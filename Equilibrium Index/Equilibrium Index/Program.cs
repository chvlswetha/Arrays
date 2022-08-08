using System;

namespace Equilibrium_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {5,4,2,3,12};
            int n = arr.Length;

            int ei = Equilibrium(arr, n);
            if(ei == -1)
            {
                Console.WriteLine("Index not found");
            }
            else
            Console.WriteLine("Index found:"+ ei);

        }
        static int Equilibrium(int[] a, int n)
        {
            int allSum = 0;
            int newSum = 0, i = 0; ;

            for (i = 0; i < n; i++)
                allSum += a[i];

            for (i=0; i < n; i++)
            {
                allSum -= a[i];
                if (allSum == newSum)
                    return i;
                newSum += a[i];
            }
            return - 1;
        }
    }
}
