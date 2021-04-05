using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrencesInArray
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            var hashTable = new Dictionary<int, int>();

            for(var i = 0; i < a.Length; i++)
            {
                if (hashTable.ContainsKey(a[i])){
                    hashTable[a[i]]++;
                }
                else
                {
                    hashTable[a[i]] = 1;
                }                
            }

            var unpairedElement = hashTable.Single(x => x.Value % 2 != 0).Key;

            Console.WriteLine($"Unpaired element for array {string.Join(',', a)} is {unpairedElement}");
            return unpairedElement;
        }
    }
}
