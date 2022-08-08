using System;

namespace SplitArray_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 0, 1, 2, 3, 4, 10 };
            int[] a1 = new int[a.Length - 1];
            int[] a2 = new int[1];

            int sum = 0, j = 0;

            String str = "";

            //sum calculation

            for (int i = 0; i < a.Length; i++)
            {
                sum += a[i];
            }

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == (sum -a[i]))
                {
                    a2[0] = a[i];
                    Console.WriteLine("Sum of n-1 elemnts:" + a2[0]);
                }
                else
                {
                    a1[j] = a[i];
                    str += a1[j] + ",";
                    j++;
                }
            }
            Console.WriteLine("All n-1 elements in the array: " + str);
        }
    }
}
