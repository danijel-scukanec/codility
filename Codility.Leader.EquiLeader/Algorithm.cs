using System.Collections.Generic;

namespace Codility.Leader.EquiLeader
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            if (a.Length < 2)
            {
                return 0;
            }

            int maxOccurrences = 0;
            int? leader = null;
            var hashtable = new Dictionary<int, int>();

            for (var i = 0; i < a.Length; i++)
            {
                if (!hashtable.ContainsKey(a[i]))
                {
                    hashtable.Add(a[i], 1);
                }
                else
                {
                    hashtable[a[i]]++;
                }

                if (hashtable[a[i]] > maxOccurrences)
                {
                    maxOccurrences = hashtable[a[i]];
                    if (!leader.HasValue && maxOccurrences > a.Length / 2)
                    {
                        leader = a[i];
                    }
                }
            }

            if (!leader.HasValue)
            {
                return 0;
            }

            int leftOccurrences = 0;
            int rightOccurences = 0;
            int numberOfEquiLeaders = 0;

            for (var i = 0; i < a.Length - 1; i++)
            {
                if(a[i] == leader)
                {
                    leftOccurrences++;
                }

                rightOccurences = maxOccurrences - leftOccurrences;

                if(leftOccurrences > (i + 1) / 2 && rightOccurences > (a.Length - i - 1) / 2)
                {
                    numberOfEquiLeaders++;
                }
            }

            return numberOfEquiLeaders;
        }
    }
}
