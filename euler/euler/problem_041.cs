using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace euler
{
    public class problem_041
    {
        public problem_041()
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            long big_prime_pandigit = 0;

            for (long i = 9999999999; i > 1; i--)
            {
                if (Utils.isPandigital(i, 0, 9) && Utils.isPrime(i))
                {
                    big_prime_pandigit = i;
                    break;
                }
            }

            bool pandigital = Utils.isPandigital(9876543210, 0, 9);

            Console.WriteLine("Problem 059");
            Console.WriteLine();
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
