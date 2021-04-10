using System;

namespace Codility.StacksAndQueues.StoneWall
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            var heights1 = new[] { 8, 8, 5, 7, 9, 8, 7, 4, 8 };
            var result1 = algorithm.Solution(heights1);
            Print(heights1, result1);

            var heights2 = new int[] { };
            var result2 = algorithm.Solution(heights2);
            Print(heights2, result2);

            var heights3 = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            var result3 = algorithm.Solution(heights3);
            Print(heights3, result3);

            var heights4 = new[] { 8, 7, 6, 5, 4, 3, 2, 1 };
            var result4 = algorithm.Solution(heights4);
            Print(heights4, result4);

            var heights5 = new[] { 1, 1, 1, 1, 1, 1, 1, 1 };
            var result5 = algorithm.Solution(heights5);
            Print(heights5, result5);

            var heights6 = new[] { 1, 2, 3, 2, 1, 2, 3, 3 };
            var result6 = algorithm.Solution(heights6);
            Print(heights6, result6);
        }

        private static void Print(int[] heights, int result)
        {
            Console.WriteLine($"Array {string.Join(',', heights)} use {result} elements.");
        }
    }
}
