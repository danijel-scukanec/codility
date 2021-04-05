using System;
using System.Diagnostics;

namespace Codility.TimeComplexity.FrogJmp
{
    public class Algorithm
    {
        public int Solution1(int x, int y, int d)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            if (x == y)
            {
                return 0;
            }

            var counter = 0;
            while (x < y)
            {
                counter++;
                x += d;
            }

            stopwatch.Stop();

            Console.WriteLine($"Solution for x={x}, y={y}, d={d} is {counter} resolved in {stopwatch.Elapsed}");
            return counter;
        }

        public int Solution2(int x, int y, int d)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            if (x == y)
            {
                return 0;
            }

            var counter = (y - x) / d;
            var remainder = (y - x) % (double)d;
            if(remainder > 0)
            {
                counter++;
            }

            stopwatch.Stop();

            Console.WriteLine($"Solution for x={x}, y={y}, d={d} is {counter} resolved in {stopwatch.Elapsed}");
            return counter;
        }
    }
}
