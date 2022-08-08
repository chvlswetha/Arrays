using System;

namespace Non_Duplicate
{
    class Program
    {
        static int findNonDuplicate(int[] ar, int ar_size)
        {
            int st = 0;
            int en = ar_size - 1;
            int mid;

            if (st == en)
                return ar[st];

            if (ar[st] != ar[st + 1])
                return ar[st];

            if (ar[en] != ar[en - 1])
                return ar[en];

            while (st <= en)
            {
                mid = st + (en - st) / 2;

                if (ar[mid] != ar[mid - 1] && ar[mid] != ar[mid + 1])
                    return ar[mid];

                if(((ar[mid] != ar[mid-1] && ar[mid] == ar[mid+1]) ||
                        (ar[mid] == ar[mid-1] && ar[mid] != ar[mid+1] )) &&
                        mid %2 !=0 )
                        {

                       st = mid + 1;
                      }

                else if (((ar[mid] != ar[mid - 1] && ar[mid] == ar[mid + 1]) ||
                        (ar[mid] == ar[mid - 1] && ar[mid] != ar[mid + 1])) &&
                        mid % 2 == 0)
                {
                    en = mid - 1;
                }

            }

            return -1;
        }
        static void Main(string[] args)
        {
            int[] ar = { 1, 1, 2, 2, 3, 3, 4, 4, 5, 10, 10 };

            int n = ar.Length;

            int unique = findNonDuplicate(ar, n);

            if (unique == -1)
            {
                Console.Write("No unique element");
            }
            else
                Console.Write("unique element is:" + unique);
        }
    }
}
