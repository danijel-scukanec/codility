using System;

namespace Codility.Sorting.Triangle
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            if (a.Length < 3)
            {
                PrintResult(a, 0);
                return 0;
            }

            Array.Sort(a);
            for (var i = 2; i < a.Length; i++)
            {
                if ((long)a[i - 2] + a[i - 1] > a[i])
                {
                    PrintResult(a, 1);
                    return 1;
                }
            }

            PrintResult(a, 0);
            return 0;
        }

        private void PrintResult(int[] a, int result)
        {
            Console.WriteLine($"Result of triangle for array {string.Join(',', a)} is {result}");
        }
    }
}
