using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_028
    {

        void fill(ref int[,] m, ref int x, ref int y, ref int i, ref int dir, ref int olddir, ref int call, ref int length, int dim)
        {
            if (call % 2 == 0)
                length++;
            if (call == 2)
                call = 0;


            for (int j = 0; j < length; j++)
            {
                if (j > 0)
                    i++;

                if (i == dim * dim - 1)
                    return;

                if (dir == 1)
                    x++;

                if (dir == 2)
                    y--;

                if (dir == 3)
                    x--;

                if (dir == 4)
                    y++;

                m[x, y] = i + 2;
            }
        }

        public problem_028()
        {
            const int dim = 1001;
            int[,] matrix = new int[dim, dim];
            int x = 500;
            int y = 500;
            int dir = 0;
            int olddir = -1;
            int call = 0;
            int length = 0;
            int sum = 0;
            matrix[x, y] = 1;
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // fill matrix
            for (int i = 0; i < dim * dim; i++)
            {
                dir++;
                fill(ref matrix, ref x, ref y, ref i, ref dir, ref olddir, ref call, ref length, dim);
                call++;

                if (dir == 4)
                {
                    dir = 0;
                }
            }

            // sum diagonals
            for (int i = 0; i < dim; i++)
            {
                sum += matrix[i, i];
                sum += matrix[i, dim - i - 1];
            }
            sum--;

            Console.WriteLine("Problem 028");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
