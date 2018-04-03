using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_031
    {
        int[] coins = { 200, 100, 50, 20, 10, 5, 2, 1 };

        int findways(int money, int maxcoin)
        {
            int sum = 0;
            if (maxcoin == 7) return 1;
            for (int i = maxcoin; i < 8; i++)
            {
                if (money - coins[i] == 0)
                    sum += 1;
                if (money - coins[i] > 0)
                    sum += findways(money - coins[i], i);
            }
            return sum;
        }


        public problem_031()
        {
            int cnt = 0;
            int sum = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            cnt = findways(200, 0);

            /*
            // dumb solution - BF

            for (int a = 0; a < 2; a++)                                 // 2
                for (int b = 0; b < 3; b++)                             // 1
                    for (int c = 0; c < 5; c++)                         // 0.5
                        for (int d = 0; d < 11; d++)                    // 0.20
                            for (int e = 0; e < 21; e++)                // 0.10
                                for (int f = 0; f < 41; f++)            // 0.05
                                    for (int g = 0; g < 101; g++)       // 0.02
                                        for (int h = 0; h < 201; h++)   // 0.01
                                        {
                                            sum = a * 200 + b * 100 + c * 50 + d * 20 + e * 10 + f * 5 + g * 2 + h * 1;

                                            if (sum > 200)
                                                continue;

                                            if (sum == 200)
                                                cnt++;

                                        }
            */

            Console.WriteLine("Problem 039");
            Console.WriteLine(cnt);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
