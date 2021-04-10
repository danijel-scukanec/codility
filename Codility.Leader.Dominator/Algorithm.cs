using System.Collections.Generic;

namespace Codility.Leader.Dominator
{
    public class Algorithm
    {
        public int Solution(int[] a)
        {
            if (a.Length == 0)
            {
                return -1;
            }

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

                if (hashtable[a[i]] > (a.Length / 2))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
