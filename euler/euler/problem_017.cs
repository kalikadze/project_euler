using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace euler
{
    class problem_017
    {
        string[] basic = 
            {   // 0 - 19
                "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
            };

        string[] tens = 
            {   // 20, 30, 40, 50, 60, 70, 80, 90
                "dummy", "dummy", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"                         
            };

        string thousand = "onethousand";

        public string sumNum(int num)
        {
            bool big = false;
            if (num == 1000)
                return thousand;

            if (num > 99)
                big = true;

            string resString = "";

            for (int i = 2; i > 0; i--)
            {
                int adiv = num / (int)Math.Pow(10, i);
                int amod = num % (int)Math.Pow(10, i);
                if (i == 2 && big)
                {
                    resString = basic[adiv] + "hundred";
                }
                if (i == 1)
                {
                    if (num > 19)
                    {
                        if (big)
                        {
                            if (amod == 0)
                                resString += "and" + tens[adiv];
                            else
                                resString += "and" + tens[adiv] + basic[amod];
                        }
                        else
                        {
                            if (amod == 0)
                                resString += tens[adiv];
                            else
                                resString += tens[adiv] + basic[amod];
                        }
                    }
                    else
                    {
                        if (big)
                        {
                            if (amod != 0)
                                resString += "and" + basic[num];
                        }
                        else
                        {
                            resString += basic[num];
                        }
                    }
                }
                num = amod;
            }

            return resString;
        }

        public problem_017()
        {
            long result = 0;
            Stopwatch sw = new Stopwatch();
            sw.Start();

            sumNum(110);
            for (int i = 1; i < 1001; i++)
            {
                string tempy = sumNum(i);
                result += sumNum(i).Length;
            }

            Console.WriteLine("Problem 017");
            Console.WriteLine(result);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
