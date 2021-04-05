using System;

namespace Codility.TimeComplexity.PermMissingElem
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();
            algorithm.Solution(new int[] {});
            algorithm.Solution(new int[] { 2, 3, 1, 5 });
        }
    }
}
