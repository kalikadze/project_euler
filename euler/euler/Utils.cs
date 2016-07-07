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
        /// get prime divisors from inserted number
        /// </summary>
        /// <param name="x">get prime divisor for this number</param>
        /// <param name="orig">same as x (original number)</param>
        /// <param name="matrix">matrix for storing results (2d array, there are stored prime divisors and their count</param>
        /// <returns></returns>
        public static int getDiv(long x, long orig, int[,] matrix)
        {
            for (int i = 2; i <= x; i++)
            {
                if (x % i == 0)
                {
                    matrix[orig, i]++;
                    getDiv(x / i, orig, matrix);
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
    }
}
