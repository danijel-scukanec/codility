using System;
using System.Collections.Generic;
using System.Linq;

namespace Codility.TimeComplexity.PermMissingElem
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {    
            var hashtable = new Dictionary<int, bool>();

            for (var i = 0; i < a.Length + 1; i++)
            {
                hashtable.Add(i + 1, false);
            }

            foreach (var element in a)
            {
                hashtable[element] = true;
            }

            var missingElement = hashtable.Single(x => x.Value == false).Key;
            Console.WriteLine($"Missing element is {missingElement}");
            
            return missingElement;
        }
    }
}
