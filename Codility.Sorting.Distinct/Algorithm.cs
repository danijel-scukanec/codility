using System;
using System.Collections.Generic;

namespace Codility.Sorting.Distinct
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            var hashtable = new Dictionary<int, int>();

            foreach(var element in a)
            {
                if (!hashtable.ContainsKey(element))
                {
                    hashtable.Add(element, 0);
                }
            }

            Console.WriteLine($"Array {string.Join(',', a)} has {hashtable.Count} distinct values");
            return hashtable.Count;
        } 
    }
}
