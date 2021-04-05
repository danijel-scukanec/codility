using System;

namespace Codility.TimeComplexity.FrogJmp
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();
            algorithm.Solution1(10, 85, 30);
            algorithm.Solution1(1, 1000000000, 1);
            algorithm.Solution2(10, 85, 30);
            algorithm.Solution2(1, 1000000000, 1);
        }
    }
}
