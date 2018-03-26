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

            allprimsum = primes.Take((int)primes.Count).Sum();

            for (long i = primes.Count - 1; i > -1; i--)
            {
                allprimsum = allprimsum - primes[(int)i];
                sum = allprimsum;

                if (sum > border)
                    continue;
                
                for (int j = 0; j < i; j++)
                {
                    if (sum < border && Utils.isPrime(sum))
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


            /*
CHECK THIS SOLUTION FROM FORUM             
public class Task50 {

	public static void main(String[] args) {
		int largest, answer, sum, count;
		count = sum = answer = largest = 0;
		for (int i = 2; i < 1000000; i++) { 
			if (isPrime(i)) {
				count = sum = 0;
				for (int x = i; sum < 1000000; x++) { 
					if(isPrime(x)) {
						sum += x;
						count++;
						if (isPrime(sum) && sum < 1000000 && count > largest) { 
							largest = count;
							answer = sum;
						}
					}
				}
			}
		}
		System.out.println(answer + " " + largest);

	}
	
	public static boolean isPrime(int num) {
		boolean isPrime = true;
		int factors = 0;
		for (int x = 1; x * x <= num; x++) {
			if (num % x == 0) factors += 2;
			if (factors > 2) { 
				isPrime = false;
				break;
			}
		}

		return isPrime;
	}
	

}
*/
        }
    }
}
