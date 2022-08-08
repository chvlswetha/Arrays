using System;

namespace _N_1_ElementsandSum
{
    class Program
    {
        static int[] splitarray(int[] arr)
        {
            //Find sum
            int sum = 0, diff = 0;
            int[] a1,a2;

            a1 = new int[1];
            a2 = new int[arr.Length - 1];

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            for (int i = 0; i< arr.Length; i++)
            {
                diff = sum - arr[i];
                if (diff == arr[i])
                {
                    a1.add(arr[i]);
                    return a1;
                }
                else
                    a2.add(a2[i]);
            }
            return a2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
