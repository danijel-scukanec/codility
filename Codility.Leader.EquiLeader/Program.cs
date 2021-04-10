using System;

namespace Codility.Leader.EquiLeader
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            var array1 = new int[] { 4, 3, 4, 4, 4, 2 };
            var result1 = algorithm.Solution(array1);
            Print(array1, result1);

            var array2 = new int[] { };
            var result2 = algorithm.Solution(array2);
            Print(array2, result2);

            var array3 = new int[] { -100 };
            var result3 = algorithm.Solution(array3);
            Print(array3, result3);

            var array4 = new int[] { -55, 0 };
            var result4 = algorithm.Solution(array4);
            Print(array4, result4);

            var array5 = new int[] { 0, 0 };
            var result5 = algorithm.Solution(array5);
            Print(array5, result5);

            var array6 = new int[] { 1, 2, 1, 2, 1, 2 };
            var result6 = algorithm.Solution(array6);
            Print(array6, result6);

            var array7 = new int[] { 1, 1, 1, 1, 1, 1 };
            var result7 = algorithm.Solution(array7);
            Print(array7, result7);

            var array8 = new int[] { -3, -3, -3, 5, 5, 5, 5 };
            var result8 = algorithm.Solution(array8);
            Print(array8, result8);

            var array9 = new int[] { -3, -3, -3, 5, 5, 5, 5, 5 };
            var result9 = algorithm.Solution(array9);
            Print(array9, result9);
        }

        private static void Print(int[] a, int result)
        {
            Console.WriteLine($"Number of equi leaders for array {string.Join(',', a)} is {result}");
        }
    }
}
