using System;

namespace Adjectent_element_difference
{
    class Program
    {
       static int findElement (int[] a, int x)
        {
            int i = 0;

            while(i < a.Length)
            {
                if(a[i] == x)
                {
                    return i;
                }
                i = i + Math.Abs(a[i] - x);
            }

            return -1;
        }
       static void Main(string[] args)
        {
            //Search an element in an array
            //where difference between adjacent elements is 1.

            int[] a = {8,7,6,7,6,5,4,3,2,3,4,3 };

            int x = 1;

            int retval = findElement(a, x);

            if (retval == -1)
            {
                Console.WriteLine("Element not found");
            }
            else
            {
                Console.WriteLine("Element found at Index:" + retval);
            }



        }
    }
}
