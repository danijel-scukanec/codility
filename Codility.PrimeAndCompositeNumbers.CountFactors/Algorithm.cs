using System;

namespace Codility.PrimeAndCompositeNumbers.CountFactors
{
    public class Algorithm
    {
        public int SolutionBad(int n)
        {
            var counter = 0;
            for (var i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    counter++;
                }
            }

            return counter;
        }

        public int Solution(int n)
        {
            var counter = 0;
            var limit = (int)Math.Sqrt(n);

            for (var i = 1; i <= limit; i++)
            {
                if (n % i == 0)
                {
                    counter += 2;
                }
            }

            if (limit == Math.Sqrt(n))
            {
                counter--;
            }

            return counter;
        }
    }
}
