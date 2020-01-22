using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_082
    {
        public int counter = 0;
        public int minVal(int m, int n, int[][] mat)
        {
            int i, j;

            int[,] subVal = new int[m + 1, n + 1];

            counter++;
            subVal[0, 0] = mat[0][0];

            // first column of subVal array
            for (i = 1; i <= m; i++)
                subVal[i, 0] = subVal[i - 1, 0] + mat[i][0];
            // first row of subVal array
            for (j = 1; j <= n; j++)
                subVal[0, j] = subVal[0, j - 1] + mat[0][j];
            // body of subVal array
            for (i = 1; i <= m; i++)
                for (j = 1; j <= n; j++)
                {
                    subVal[i, j] = Math.Min(subVal[i - 1, j], subVal[i, j - 1]) + mat[i][j];
                }
            return subVal[m, n];
        }

        public problem_082()
        {
            string f = @"..\..\problem_082_short.in";
            List<int> linenum = new List<int>();
            List<List<int>> matrixList = new List<List<int>>();
            
            int sum = 0;

            using (StreamReader r = new StreamReader(f))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    linenum = Array.ConvertAll<string, int>(line.Split(','), int.Parse).ToList();
                    matrixList.Add(linenum);
                }
            }
            int[][] matrix = matrixList.Select(a => a.ToArray()).ToArray();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            sum = minVal(matrixList.Count - 1, matrixList[0].Count - 1, matrix);

            Console.WriteLine("Problem 081");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);


        }
    }
}
