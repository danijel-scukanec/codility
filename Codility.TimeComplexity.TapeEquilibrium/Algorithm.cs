using System;

namespace Codility.TimeComplexity.TapeEquilibrium
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            int sumLeft = a[0];
            int sumRight = 0;

            for (var i = 1; i < a.Length; i++)
            {
                sumRight += a[i];
            }

            int minSum = Math.Abs(sumLeft - sumRight);

            for (var p = 2; p < a.Length; p++)
            {
                sumLeft += a[p - 1];
                sumRight -= a[p - 1];
                int intermediateSum = Math.Abs(sumLeft - sumRight);

                if (intermediateSum < minSum)
                {
                    minSum = intermediateSum;
                }
            }

            Console.WriteLine($"Min sum for array {string.Join(',', a)} is {minSum}");
            return minSum;
        }
    }
}
