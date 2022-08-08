using System;

namespace OneDuplicate
{
    class Program
    {
        static int Duplicate(int[] a)
        {
            Array.Sort(a);  //o(nlogn)
            int mid, start, end;
            start = 0;
            end = a.Length - 1;

           while (start <= end)
            {

               mid = (end+start) / 2;

                if ((a[mid] == a[mid - 1]) || (a[mid] == a[mid + 1]))
                    return a[mid];

                if (a[mid] == mid)
                    end = mid - 1;               
                else
                    start = mid + 1;
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] A = {7,6,4,3,1,2,5,3};
            
            int retval = Duplicate(A);

            if (retval == -1)
                Console.WriteLine("The duplicate element not found");
           else
               Console.WriteLine("The duplicate element is:" + retval);
        }
    }
}
