using System;

namespace Codility.Leader.Dominator
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            //var array1 = new[] { 3, 4, 3, 2, 3, -1, 3, 3 };
            //var result1 = algorithm.Solution(array1);
            //Print(array1, result1);

            //var array2 = new int[] { };
            //var result2 = algorithm.Solution(array2);
            //Print(array2, result2);

            //var array3 = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //var result3 = algorithm.Solution(array3);
            //Print(array3, result3);

            //var array4 = new[] { 1, 1, 1, 1, 2, 2, 2, 2 };
            //var result4 = algorithm.Solution(array4);
            //Print(array4, result4);

            //var array5 = new[] { -10, 1, -10, 2, -10, -10, -10, 5 };
            //var result5 = algorithm.Solution(array5);
            //Print(array5, result5);

            var array6 = new[] { -10};
            var result6 = algorithm.Solution(array6);
            Print(array6, result6);
        }

        private static void Print(int[] array, int result)
        {
            Console.WriteLine($"Result for array {string.Join(',', array)} is {result}");
        }
    }
}
