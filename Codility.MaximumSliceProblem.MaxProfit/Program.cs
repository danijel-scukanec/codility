using System;

namespace Codility.MaximumSliceProblem.MaxProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            var array1 = new int[] { 23171, 21011, 21123, 21366, 21013, 21367 };
            var result1 = algorithm.Solution(array1);
            Print(array1, result1);
        }

        private static void Print(int[] a, int profit)
        {
            Console.WriteLine($"Profit for array {string.Join(',', a)} is {profit}");
        }
    }
}
