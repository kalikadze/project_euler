using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_049
    {
        public problem_049()
        {
            string sum = "";
            List<int> primes = new List<int>();
            List<int> permuts = new List<int>();
            List<int> primePermuts = new List<int>();
            List<int> targets = new List<int>();
            List<int> searched = new List<int>();


            int[] arr = new int[4];

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // need all primes between 1000 and 9999
            for (int i = 1000; i < 10000; i++)
                if (Utils.isPrime(i))
                    primes.Add(i);

            // need to make permutations of given prime and check if this permutation 
            // is again prime
            // try it faster with shift&rotation
            for (int i = 0; i < primes.Count; i++)
            {
                permuts.Clear();

                for (int j = 0; j < 4; j++)
                {
                    arr[j] = (int)primes[i].ToString()[j] - 48;
                }

                Utils.heapPermutation(arr, arr.Length, ref permuts, false);
                // remove duplicates
                permuts = permuts.Distinct().ToList();

                for (int j = 0; j < permuts.Count; j++)
                {

                    if (Utils.isPrime(permuts[j]) && permuts[j] > 1000)
                    {
                        primePermuts.Add(permuts[j]);
                    }
                }

                if (primePermuts.Count >= 3)
                {
                    primePermuts.Sort();
                    // there is need to check for increasing sequence made of three of those numbers

                    for (int k = 0; k < primePermuts.Count; k++)
                    {
                        for (int l = k; l < primePermuts.Count; l++)
                        {
                            int delta = primePermuts[l] - primePermuts[k];
                            if (delta != 0)
                            {
                                for (int m = k; m < primePermuts.Count; m++)
                                {
                                    if (primePermuts.Contains(primePermuts[m]) && primePermuts.Contains(primePermuts[m] + (1 * delta)) && primePermuts.Contains(primePermuts[m] + (2 * delta)))
                                    {
                                        targets.Add(primePermuts[m] + (0 * delta));
                                        targets.Add(primePermuts[m] + (1 * delta));
                                        targets.Add(primePermuts[m] + (2 * delta));
                                    }
                                }
                                if (targets.Count < 3)
                                    targets.Clear();
                                else
                                {
                                    for (int n = 0; n < targets.Count; n++)
                                        searched.Add(targets[n]);
                                    targets.Clear();
                                }
                            }
                        }
                    }
                    //break;
                }                    
                primePermuts.Clear();
                searched = searched.Distinct().ToList();
            }

            Console.WriteLine("Problem 050");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
