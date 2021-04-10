using System;

namespace Codility.PrimeAndCompositeNumbers.MinPerimeterRectangle
{
    public class Algorithm
    {
        public int SolutionGood(int n)
        {
            var minPerimeter = int.MaxValue;

            var limit = (int)Math.Sqrt(n);
            for (var i = 1; i <= limit; i++)
            {
                if (n % i == 0)
                {
                    var a = i;
                    var b = n / i;
                    var perimeter = 2 * (a + b);
                    minPerimeter = Math.Min(perimeter, minPerimeter);
                }
            }

            return minPerimeter;
        }

        public int SolutionBetter(int n)
        {
            var limit = (int)Math.Sqrt(n);
            for (var i = limit; i > 0; i--)
            {
                if (n % i == 0)
                {
                    return 2 * (i + n / i);
                }
            }

            return int.MaxValue;
        }

    }
}
