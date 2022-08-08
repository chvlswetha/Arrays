using System;

namespace sortarray0_1_2
{

    // Write a program to sort an array of 0's,1's and 2's in ascending order.
    
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1,1,2,1,2,0,1};

            int s = 0, m = 0, e = a.Length - 1, temp;

            while (m <= e)
            {
                switch (a[m])
                {
                    case 0:
                        temp = a[m];
                        a[m] = a[s];
                        a[s] = temp;
                        s++;
                        m++;
                        break;

                    case 1:
                        m++;
                        break;

                    case 2:
                        temp = a[m];
                        a[m] = a[e];
                        a[e] = temp;
                         e--;
                        break;

                }
            }
                Console.WriteLine("o/p array :");
                for (int i = 0; i < a.Length; i++)
                    Console.Write(a[i] + ",");
             }
    }
}
