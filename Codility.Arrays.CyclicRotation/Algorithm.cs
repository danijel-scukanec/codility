using System;

namespace Codility.Arrays.CyclicRotation
{
    public class Algorithm
    {
        public int[] Solution(int[] a, int k)
        {
            if (a.Length <= 1 || k == 0 || k % a.Length == 0)
            {
                PrintResult(a, k, a);
                return a;
            }

            var result = new int[a.Length];
            Array.Copy(a, result, a.Length);

            for (var i = 0; i < k; i++)
            {
                var intermediateResult = new int[result.Length];
                intermediateResult[0] = result[result.Length - 1];

                for (var j = 0; j < result.Length - 1; j++)
                {
                    intermediateResult[j + 1] = result[j];
                }

                result = intermediateResult;
            }

            PrintResult(a, k, result);
            return result;
        }    

        private void PrintResult(int[] a, int k, int[] result)
        {
            Console.WriteLine($"Solution for array {string.Join(',', a)} rotated {k} times is {string.Join(',', result)}");
        }
    }
}