using System;

namespace Codility.MaximumSliceProblem.MaxProfit
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            var profit = 0;
            if (a.Length <= 1)
            {
                return profit;
            }

            Array.Sort(a);
            profit = a[a.Length - 1] - a[0];

            return profit >= 0 ? profit : 0;
        }
    }
}
