using System;

namespace Leader
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 16, 17, 4, 3, 5, 2 };
            int n = a.Length -1;
             findleader(a,n);
        }

        static void findleader(int[] a, int n)
        {
            Console.WriteLine("Leaders : " + a[n] + ",");
            int leader = a[n];
            for(int i=n-1;  i>=0; i--)
            {
                if(leader < a[i])
                {
                    leader = a[i];
                    Console.Write( a[i] + ",");
                }
            }
        }
    }
}
