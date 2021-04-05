using System;

namespace Codility.TimeComplexity.TapeEquilibrium
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();
            algorithm.Solution(new int[] { 4 });
            algorithm.Solution(new int[] { 4, 2 });
            algorithm.Solution(new int[] { 3, 1, 2, 4, 3 });
            algorithm.Solution(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }
    }
}
