using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace euler
{
    class problem_082
    {
        public int counter = 0;
        public int minVal(int m, int n, int[,] mat)
        {
            int i, j;

            int[,] subVal = new int[m + 1, n + 1];

            counter++;
            subVal[0, 0] = mat[0, 0];

            Console.Clear();

            // first column of subVal array
            for (i = 1; i <= m; i++)
            {
                subVal[i, 0] = subVal[i - 1, 0] + mat[i, 0];
                printMatrix(mat, 0, 0);
                Thread.Sleep(1000);
                printMatrix(subVal, 0, 7);
                Thread.Sleep(1000);
            }
            // first row of subVal array
            for (j = 1; j <= n; j++)
            {
                subVal[0, j] = subVal[0, j - 1] + mat[0, j];
                printMatrix(mat, 0, 0);
                Thread.Sleep(1000);
                printMatrix(subVal, 0, 7);
                Thread.Sleep(1000);
            }
            // body of subVal array
            for (i = 1; i <= m; i++)
                for (j = 1; j <= n; j++)
                {
                    subVal[i, j] = Math.Min(subVal[i - 1, j], subVal[i, j - 1]) + mat[i, j];
                    printMatrix(mat, 0, 0);
                    Thread.Sleep(1000);
                    printMatrix(subVal, 0, 7);
                    Thread.Sleep(1000);
                }
            return subVal[m, n];
        }

        public void printMatrix(int[,] mat, int startx, int starty)
        {
            int dimx = mat.GetLength(0);
            int dimy = mat.GetLength(1);

            for (int i = 0; i < dimx; i++)
                for (int j = 0; j < dimy; j++)
                {
                    Console.SetCursorPosition(startx + (i * 5), starty + (j * 1));
                    Console.Write(mat[i, j]);
                }
        }

        /// <summary>
        /// credit to: stackoverflow: Thomas Lavesque JaggedToMultidimensional
        /// https://stackoverflow.com/questions/1781172/generate-a-two-dimensional-array-via-linq/1814063#1814063
        /// https://stackoverflow.com/questions/13724781/2d-array-from-text-file-c-sharp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="jaggedArray"></param>
        /// <returns></returns>
        public T[,] JaggedToMultidimensional<T>(T[][] jaggedArray)
        {
            int rows = jaggedArray.Length;
            int cols = jaggedArray.Max(subArray => subArray.Length);
            T[,] array = new T[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                cols = jaggedArray[i].Length;
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = jaggedArray[i][j];
                }
            }
            return array;
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
            int[][] matrixFromList = matrixList.Select(a => a.ToArray()).ToArray();
            int[,] matrix = JaggedToMultidimensional(matrixFromList);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            sum = minVal(matrixList.Count - 1, matrixList[0].Count - 1, matrix);

            Console.WriteLine("\n\nProblem 081");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);


        }
    }
}
