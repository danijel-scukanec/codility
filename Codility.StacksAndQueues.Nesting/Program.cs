using System;

namespace Codility.StacksAndQueues.Nesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();

            var string1 = "(()(())())";
            var result1 = algorithm.Solution(string1);
            Print(string1, result1);

            var string2 = "())";
            var result2 = algorithm.Solution(string2);
            Print(string2, result2);

            var string3 = "";
            var result3 = algorithm.Solution(string3);
            Print(string3, result3);

            var string4 = "(((";
            var result4 = algorithm.Solution(string4);
            Print(string4, result4);

            var string5 = ")))";
            var result5 = algorithm.Solution(string5);
            Print(string5, result5);
        }

        private static void Print(string s, int result)
        {
            if(result == 0)
            {
                Console.WriteLine($"String {s} is not properly nested.");
            }
            else
            {
                Console.WriteLine($"String {s} is properly nested.");
            }
        }
    }
}
