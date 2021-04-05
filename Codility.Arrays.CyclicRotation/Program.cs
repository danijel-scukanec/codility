namespace Codility.Arrays.CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();
            algorithm.Solution(new int[] { 3, 8, 9, 7, 6 }, 3);
            algorithm.Solution(new int[] { 0, 0, 0 }, 1);
            algorithm.Solution(new int[] { 1, 2, 3, 4 }, 4);
            algorithm.Solution(new int[] { 3, 8, 9, 7, 6 }, 3);
            algorithm.Solution(new int[] { 0, 0, 0 }, 1);
            algorithm.Solution(new int[] { 1, 2, 3, 4 }, 4);
        }
    }
}
