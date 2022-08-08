using System;
using System.Collections.Generic;

namespace Elements_decreasing_frequency
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] arr = { 2, 5, 2, 8, 5, 6, 8, 8 };
            int n = arr.Length;

            List<int> a = new List<int>(arr);

            sortfrqidx(a,arr,n);
        }

        static void sortfrqidx(List<int> a, int[] arr, int n)
        {
            Dictionary<int, int> frq = new Dictionary<int, int>();

            Dictionary<int, int> idx = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
            if (frq.ContainsKey(arr[i]))
                frq[arr[i]]++;
                else
                {
                    frq.Add(arr[i], 1);
                    idx.Add(arr[i], i);
                }
              a.Sort((int i, int j) => frq[i] != frq[j] ? frq[j].CompareTo(frq[i]) : idx[j].CompareTo(idx[i]));

            foreach (var i in a) Console.Write(i + " ");
        }
    }
}
