using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_050
    {
        public problem_050()
        {
            long sum = 0;
            long max = 0;
            long maxlen = 0;
            List<long> primes = new List<long>();
            List<long> tempy = new List<long>();
            long border = 1000000;
            long allprimsum = 0;
            
            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (long i = 2; i < border; i++)
            {
                if (Utils.isPrime(i))
                    primes.Add(i);
            }

            //allprimsum = primes.Sum(ind => (int)ind);
            //sum = allprimsum;


            for (long i = primes.Count - 1; i > -1; i--)
            {
                sum = 0;
                for (long k = i; k > -1; k--)
                    sum += primes[(int)k];

                if (sum > border)
                    continue;
                
                for (int j = 0; j < i; j++)
                {
                    if (primes.Contains(sum))
                    {
                        if (i - j > maxlen)
                        {
                            max = sum;
                            maxlen = i - j;
                        }
                    }

                    sum -= primes[j];
                }
            }
            
            Console.WriteLine("Problem 050");
            Console.WriteLine(max);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
