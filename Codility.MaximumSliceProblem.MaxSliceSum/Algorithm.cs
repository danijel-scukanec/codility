using System;

namespace Codility.MaximumSliceProblem.MaxSliceSum
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            var maxEnding = a[0];
            var maxSlice = a[0];

            for (var i = 1; i < a.Length; i++)
            {
                maxEnding = Math.Max(a[i], maxEnding + a[i]);
                maxSlice = Math.Max(maxSlice, maxEnding);
            }

            return maxSlice;
        }
    }
}
