using System;
using System.Collections.Generic;

namespace Codility.CountingElements.PermCheck
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            var hashtable = new Dictionary<int, bool>();
            for(var i = 1; i <= a.Length; i++)
            {
                hashtable.Add(i, false);
            }

            foreach (var element in a)
            {
                if (hashtable.ContainsKey(element))
                {
                    hashtable[element] = true;
                }
            }

            var isPermutation = !hashtable.ContainsValue(false);
            var result = isPermutation ? 1 : 0;

            Console.WriteLine($"Array {string.Join(',', a)} result of permutation check is {result}");
            return result;
        }
    }
}
