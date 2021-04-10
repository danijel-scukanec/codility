using System.Collections.Generic;

namespace Codility.StacksAndQueues.Nesting
{
    public class Algorithm
    {
        public int Solution(string s)
        {
            if (s.Length == 0)
            {
                return 1;
            }

            var stack = new Stack<char>();

            for (var i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push('(');
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    stack.Pop();
                }
            }

            return stack.Count == 0 ? 1 : 0;
        }
    }
}
