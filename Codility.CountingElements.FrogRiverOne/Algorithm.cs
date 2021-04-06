using System;
using System.Collections.Generic;

namespace Codility.CountingElements.FrogRiverOne
{
    public class Algorithm
    {
        public int Solution(int x, int[] a)
        {
            if (x == 0)
            {
                PrintResult(x, a, 0);
                return 0;
            }

            if (a.Length == 0)
            {
                PrintResult(x, a, -1);
                return -1;
            }

            var hashtable = new Dictionary<int, bool>();

            for (var i = 0; i < a.Length; i++)
            {
                if (!hashtable.ContainsKey(a[i]))
                {
                    hashtable.Add(a[i], true);

                    if (hashtable.Count == x)
                    {
                        PrintResult(x, a, i);
                        return i;
                    }
                }              
            }

            PrintResult(x, a, -1);
            return -1;
        }

        private void PrintResult(int x, int[] a, int seconds)
        {
            Console.WriteLine($"Frog needs {seconds} seconds to get to the other side of the river for x={x} and a={string.Join(',', a)}");
        }
    }
}
