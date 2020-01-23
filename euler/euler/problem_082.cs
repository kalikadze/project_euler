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
            int del = 500;

            int[,] subVal = new int[m + 1, n + 1];

            counter++;
            subVal[0, 0] = mat[0, 0];
            printElement(mat, 0, 0, 0, 0, ConsoleColor.Yellow, del);
            printElement(subVal, 0, 7, 0, 0, ConsoleColor.Yellow, del);
            printElement(mat, 0, 0, 0, 0, ConsoleColor.Gray, del);
            printElement(subVal, 0, 7, 0, 0, ConsoleColor.Gray, del);

            // first column of subVal array
            for (i = 1; i <= m; i++)
            {
                subVal[i, 0] = subVal[i - 1, 0] + mat[i, 0];
                showCalc(mat, subVal, 0, 0, 0, 7, i, 0, ConsoleColor.Yellow, ConsoleColor.Gray, del, -1, 0);
            }
            // first row of subVal array
            for (j = 1; j <= n; j++)
            {
                subVal[0, j] = subVal[0, j - 1] + mat[0, j];
                showCalc(mat, subVal, 0, 0, 0, 7, 0, j, ConsoleColor.Yellow, ConsoleColor.Gray, del, 0, -1);
            }
            // body of subVal array
            for (i = 1; i <= m; i++)
                for (j = 1; j <= n; j++)
                {
                    subVal[i, j] = Math.Min(subVal[i - 1, j], subVal[i, j - 1]) + mat[i, j];
                    showCalc(mat, subVal, 0, 0, 0, 7, i, j, ConsoleColor.Yellow, ConsoleColor.Gray, del, -1, -1);
                }

            // mark desired way
            markPath(subVal, 4, 4);

            return subVal[m, n];
        }

        public void markPath(int[,] mat, int x, int y)
        {
            int dimx = mat.GetLength(0);
            int dimy = mat.GetLength(1);

            if (x == dimx - 1 || y == dimy - 1)
                printElement(mat, 0, 7, x, y, ConsoleColor.Green, 500);


            if (x == 0 || y == 0)
                return;
            else
            {
                if (mat[x, y - 1] < mat[x - 1, y])
                {
                    y--;
                    printElement(mat, 0, 7, x, y, ConsoleColor.Green, 500);
                    markPath(mat, x, y);
                }
                else
                {
                    x--;
                    printElement(mat, 0, 7, x, y, ConsoleColor.Green, 500);
                    markPath(mat, x, y);

                }
            }
            printElement(mat, 0, 7, 0, 0, ConsoleColor.Green, 500);
        }

        public void showCalc(int[,] origMat, int[,] newMat, int startX_orig, int startY_orig, int startX_new, int startY_new, int x, int y, ConsoleColor sel, ConsoleColor col, int del, int xmove, int ymove)
        {
            printElement(origMat, startX_orig, startY_orig, x, y, sel, del);
            printElement(newMat, startX_new, startY_new, x + xmove, y + ymove, sel, del);
            printElement(newMat, startX_new, startY_new, x, y, sel, del);

            printElement(origMat, startX_orig, startY_orig, x, y, col, del);
            printElement(newMat, startX_new, startY_new, x + xmove, y + ymove, col, del);
            printElement(newMat, startX_new, startY_new, x, y, col, del);
        }

        public void printElement(int[,] mat, int startx, int starty, int x, int y, ConsoleColor col, int wait)
        {
            int dimx = mat.GetLength(0);
            int dimy = mat.GetLength(1);

            Console.SetCursorPosition(startx + (x * dimx), starty + (y * 1));
            Console.ForegroundColor = col;
            Thread.Sleep(wait);
            Console.Write(mat[x, y]);
        }

        public void printMatrix(int[,] mat, int startx, int starty, ConsoleColor col = ConsoleColor.Gray)
        {
            int dimx = mat.GetLength(0);
            int dimy = mat.GetLength(1);
            ConsoleColor remember = Console.ForegroundColor;
            Console.ForegroundColor = col;

            for (int i = 0; i < dimx; i++)
                for (int j = 0; j < dimy; j++)
                {
                    Console.SetCursorPosition(startx + (i * 5), starty + (j * 1));
                    Console.Write(mat[i, j]);
                }
            Console.ForegroundColor = remember;
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
                    array[i, j] = jaggedArray[j][i];
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

            printMatrix(matrix, 0, 0);
            sum = minVal(matrixList.Count - 1, matrixList[0].Count - 1, matrix);

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\n\n\n\n\n\n\n\nProblem 081");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
