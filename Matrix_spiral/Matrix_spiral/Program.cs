using System;

namespace Matrix_spiral
{
    class Program
    {

        //Given a 2D array, print it in spiral form
        static void Main(string[] args)
        {
            int[,] a =  {{1,2,3,4},
                               {5,6,7,8},
                              {9,10,11,12},
                              {13,14,15,16}};

            int rowlength = a.GetLength(0);
            int collength = a.GetLength(1);

            spiralprint(a, rowlength - 1, collength - 1);

        }
        static void spiralprint(int[,] a,int rows, int cols)
        {
            int rowst = 0, colst = 0, i = 0;
            int rowen = rows, colen = cols;

            Console.Write("spiralprint :{");
            while ((rowst) < rowen && (colst < colen))
            {
                for (i = colst; i <= colen; i++)
                    Console.Write(a[rowst, i] + ",");
                rowst++;
                for (i = rowst; i <= rowen; i++)
                    Console.Write(a[i, colen] + ",");
                colen--;

                for (i = colen; i >= colst; i--)
                    Console.Write(a[rowen, i] + ",");
                rowen--;

                for (i = rowen; i >= rowst; i--)
                    Console.Write(a[i, colst] + ",");
                colst++;
            }
            Console.Write("}");
        }
        

    }
}
