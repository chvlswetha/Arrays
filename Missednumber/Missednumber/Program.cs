using System;

namespace Missednumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 9, 10 };

           int sum = ((a.Length+1) * (a.Length+2))/2;
            int a_sum = 0;

            for (int i=0; i< a.Length; i++)
            {
                a_sum += a[i];
            }
            int missednumber = sum - a_sum;
            Console.WriteLine("Missed numbert is:" + missednumber);
        }
    }
}
