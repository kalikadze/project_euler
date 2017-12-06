using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler
{
    public static class Utils
    {
        public static string sep = "_____________________________";

        /// <summary>
        /// Check if argument is prime number
        /// </summary>
        /// <param name="x">long x</param>
        /// <returns>returns true if argument is prime, othervise false</returns>
        public static bool isPrime(long x)
        {
            for (int i = (int)Math.Sqrt(x); i > 1; i--)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

       /// <summary>
       /// get list of divisors of number
       /// </summary>
       /// <param name="x"></param>
       /// <returns></returns>
        public static int getDiv(long x)
        {
            //List<int> divs = new List<int>();
            int divCount = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                    divCount++;
            }
            return divCount;
        }

        /// <summary>
        /// get prime divisors from inserted number
        /// </summary>
        /// <param name="x">get prime divisor for this number</param>
        /// <param name="orig">same as x (original number)</param>
        /// <param name="matrix">matrix for storing results (2d array, there are stored prime divisors and their count</param>
        /// <returns></returns>
        public static int getPrimeDiv(long x, long orig, int[,] matrix)
        {
            for (int i = 2; i <= x; i++)
            {
                if (x % i == 0)
                {
                    matrix[orig, i]++;
                    getPrimeDiv(x / i, orig, matrix);
                    return i;
                }
            }
            return -1;
        }

        /// <summary>
        /// Check if string argument is palindrome
        /// </summary>
        /// <param name="x">string x</param>
        /// <returns>returns true if argument is palindrome, othervise false</returns>
        public static bool isPalindrome(string x)
        {
            string left = "", right = "";

            left = x.Substring(0, x.Length / 2);
            if (x.Length % 2 == 0)
                right = x.Substring(x.Length / 2, x.Length / 2);
            else
                right = x.Substring(x.Length / 2 + 1, x.Length / 2);
            char[] rightArray = right.ToCharArray();
            Array.Reverse(rightArray);
            string reverseRight = new string(rightArray);

            if (left == reverseRight)
                return true;
            else
                return false;
        }

        /// <summary>
        /// find max product in 4 ways from point in defined depth 
        /// </summary>
        /// <param name="field"></param>
        /// <param name="depth"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static long findIn4directions(int[,] field, int depth, int x, int y)
        {
            long maxProduct = 1;
            long max1 = 1, max2 = 1, max3 = 1, max4 = 1;

            int xdim = field.GetUpperBound(0) + 1;
            int ydim = field.GetUpperBound(1) + 1;

            for (int k = 0; k < depth; k++)
            {
                //right
                if (x + depth < xdim)
                {
                    max1 *= field[x + k, y];
                }
                //down
                if (y + depth <ydim)
                {
                    max2 *= field[x , y + k];
                }

                //diag down-right
                if (x + depth < xdim && y + depth < ydim)
                {
                    max3 *= field[x + k, y + k];
                }

                //diag down-left
                if (x - depth >= 0 && y + depth < ydim)
                {
                    max4 *= field[x - k, y + k];
                }
            }
            max1 = Math.Max(max1, max2);
            max3 = Math.Max(max3, max4);
            maxProduct = Math.Max(max1, max3);            

            return maxProduct;
        }

        /// <summary>
        /// return count of terms of Collatz iterations
        /// </summary>
        /// <param name="start">start of Collatz iteration</param>
        /// <returns>count of terms Collatz iteration</returns>
        public static ulong collatz(ulong start)
        {
            ulong term = start;
            ulong count = 1;

            while (term != 1)
            {
                ulong oldterm = term;

                if (term % 2 == 0)  //even
                    term /= 2;
                else
                    term = 3 * term + 1;
                if (term < 1)
                {
                    Console.WriteLine(oldterm);
                    return 0;
                }
                count++;
            }
            return count;
        }

        public static string bigsum(string a, string b)
        {
            int pnta, pntb;
            int maxlen;

            if (a.Length > b.Length)
                maxlen = a.Length;
            else
                maxlen = b.Length;

            for ()

            return null; // indicate problem
        }
    }
}
