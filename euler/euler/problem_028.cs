using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_028
    {

        void fill(ref int[,] m, ref int x, ref int y, ref int i, ref int dir)
        {
            int length = (i + 2) / 2;
            for (int j = 0; j < length; j++)
            {
                if (j > 0)
                    i++;

                m[x, y] = i + 1;


                if (dir == 1)
                    x++;
                if (dir == 2)
                    y--;
                if (dir == 3)
                    x--;
                if (dir == 4)
                    y++;

            }
        }

        public problem_028()
        {
            const int dim = 5;
            int[,] matrix = new int[dim, dim];
            int x = 2;
            int y = 2;
            int dir = 0;
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // fill matrix
            for (int i = 0; i < dim * dim; i++)
            {
                dir++;
                fill(ref matrix, ref x, ref y, ref i, ref dir);
                if (dir == 4)
                {
                    dir = 0;
                    y--;
                    x++;
                }
            }

            Console.WriteLine("Problem 028");
            Console.WriteLine();
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
