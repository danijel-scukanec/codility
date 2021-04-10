using System;

namespace Codility.PrimeAndCompositeNumbers.MinPerimeterRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            var n1 = 30;
            var result1 = algorithm.SolutionBetter(n1);
            Print(n1, result1);
        }

        private static void Print(int n, int result)
        {
            Console.WriteLine($"Number {n} has min perimeter {result}");
        }
    }
}
