using System;
using System.Collections.Generic;

namespace Codility.PrefixSums.PassingCars
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            int totalSum = 0;
            var hashtable = new Dictionary<int, int>();

            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    hashtable[i] = totalSum;
                }
                else if (a[i] == 1)
                {
                    totalSum += a[i];
                }
            }

            int counter = 0;
            foreach (var keypair in hashtable)
            {
                counter += totalSum - keypair.Value;

                if(counter > 1000000000)
                {
                    return -1;
                }
            }

            Console.WriteLine($"Number of passing cars in array {string.Join(',', a)} is {counter}");
            return counter;
        }
    }
}
