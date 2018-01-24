using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace euler
{
    class problem_019
    {
        public problem_019()
        {
            //                0   1   2   3   4   5   6   7   8   9  10  11
            int[] months = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int year = 1900;
            int suncnt = 0;
            int daycount = 0;
            int day = 0;
            int monthcount = 0;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // monday = 0
            // starting from: 1 Jan 1900 was a Monday
            // count sundays: 1 Jan 1901 to 31 Dec 2000
            while(!((daycount == 30) && (monthcount == 11) && (year == 2000))) 
            {
                if ((year % 4 == 0) || ((year % 400 == 0) && (year % 100 != 0)))
                {
                    months[1] = 29;
                }
                else
                    months[1] = 28;

                if (day == 7)
                    day = 0;

                if ((daycount == (months[monthcount] - 1)) && monthcount != 11)
                {
                    daycount = 0;
                    monthcount++;
                }

                if ((daycount == (months[monthcount] - 1)) && monthcount == 11)
                {
                    daycount = 0;
                    monthcount = 0;
                    year++;
                }

                if (year >= 1901 && day == 6 && daycount == 0)
                {
                    suncnt++;
                }


                daycount++;
                day++;
            }

            Console.WriteLine("Problem 019");
            Console.WriteLine(suncnt);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
