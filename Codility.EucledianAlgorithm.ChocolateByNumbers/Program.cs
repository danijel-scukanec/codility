using System;

namespace Codility.EucledianAlgorithm.ChocolateByNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            var n1 = 10;
            var m1 = 4;
            var result1 = algorithm.Solution(n1, m1);
            Print(n1, m1, result1);

            var n2 = 10000;
            var m2 = 999;
            var result2 = algorithm.Solution(n2, m2);
            Print(n2, m2, result2);

            var n3 = 1000000000;
            var m3 = 1000000;
            var result3 = algorithm.Solution(n3, m3);
            Print(n3, m3, result3);

            var n4 = 947853;
            var m4 = 4453;
            var result4 = algorithm.Solution(n4, m4);
            Print(n4, m4, result4);

        }

        private static void Print(int n, int m, int result)
        {
            Console.WriteLine($"For integers {n} and {m} result is {result}");
        }
    }
}
