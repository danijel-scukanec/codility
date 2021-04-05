using System;

namespace Codility.Iterations.BinaryGap
{
    public class Algorithm
    {
        public int Solution(int n)
        {
            var binary = ConvertToBinary(n);

            bool oneFound = false;
            int zeroCounter = 0;
            int maxConsecutiveZeroes = 0;

            for (var i = 0; i < binary.Length; i++)
            {
                if(binary[i] == '1')
                {
                    oneFound = true;
                    if (zeroCounter > maxConsecutiveZeroes)
                    {
                        maxConsecutiveZeroes = zeroCounter;
                    }

                    zeroCounter = 0;
                }
                else if(binary[i] == '0' && oneFound)
                {
                    zeroCounter++;
                }                               
            }

            Console.WriteLine($"Solution for {n} is {maxConsecutiveZeroes}");

            return maxConsecutiveZeroes;
        }

        private string ConvertToBinary(int n)
        {
            var binary = Convert.ToString(n, 2);
            return binary;
        }
    }
}
