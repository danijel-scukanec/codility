using System.Collections.Generic;

namespace Codility.EucledianAlgorithm.ChocolateByNumbers
{
    public class Algorithm
    {
        public int SolutionBad(int n, int m)
        {
            var hashtable = new Dictionary<int, bool>();

            for (var i = 0; i < n; i = (i + m) % n)
            {
                if (hashtable.ContainsKey(i))
                {
                    return hashtable.Count;
                }

                hashtable.Add(i, true);
            }

            return 0;
        }

        public int Solution(int n, int m)
        {
            var result = Lcm(n, m) / (long) m;
            return (int)result;
        }

        private int Gcd(int a, int b)
        {
            if (a % b == 0)
            {
                return b;
            }
            else
            {
                return Gcd(b, a % b);
            }
        }

        private long Lcm(int a, int b)
        {
            return (long) a * (b / Gcd(a, b));
        }
    }
}
