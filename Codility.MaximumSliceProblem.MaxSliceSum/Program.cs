using System;

namespace Codility.MaximumSliceProblem.MaxSliceSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            var array1 = new int[] { 3, 2, -6, 4, 0 };
            var result1 = algorithm.Solution(array1);
            Print(array1, result1);

            var array2 = new int[] { 3 };
            var result2 = algorithm.Solution(array2);
            Print(array2, result2);

            var array3 = new int[] { -10 };
            var result3 = algorithm.Solution(array3);
            Print(array3, result3);

            var array4 = new int[] { 5, -7, 3, 5, -2, 4, -1 };
            var result4 = algorithm.Solution(array4);
            Print(array4, result4);
        }

        private static void Print(int[] a, int result)
        {
            Console.WriteLine($"Array {string.Join(',', a)} has max sum {result}");
        }
    }
}
