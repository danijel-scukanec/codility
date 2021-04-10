using System;

namespace Codility.PrimeAndCompositeNumbers.CountFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            var n1 = 24;
            var result1 = algorithm.Solution(n1);
            Print(n1, result1);
        }

        private static void Print(int n, int result)
        {
            Console.WriteLine($"Number {n} has {result} factors");
        }
    }
}
