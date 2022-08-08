using System;

namespace MaxSum_Subarray
{
    class Program
    {
       
        static int findMax(int[] a)
        {
            int currSum = 0, MaxSum = 0, MaxNeg = a[0]; 

            for(int i=0; i < a.Length; i++)
            {
                //logic for -ve                
                if (a[i] <= 0 && a[i] > MaxNeg)
                    MaxNeg = a[i];
                
                currSum += a[i];
                if (currSum < 0)
                    currSum = 0;
                if (MaxSum <= currSum)
                    MaxSum = currSum;
            }
            if (MaxSum > 0)
                return MaxSum;
            else 
                return MaxNeg;

        }
        static void Main(string[] args)
        {
            int[] a = { -30,-20,-10,-40,-50,0 };

            int maxvalue = findMax(a);
            Console.WriteLine("maxsum:" + maxvalue);
        }
    }
}
