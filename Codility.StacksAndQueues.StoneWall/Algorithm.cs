using System.Collections.Generic;

namespace Codility.StacksAndQueues.StoneWall
{
    public class Algorithm
    {
        public int Solution(int[] h)
        {
            if (h.Length == 0)
            {
                return 0;
            }
            var stack = new Stack<int>();
            var numberOfBlocks = 0;

            for (var i = 0; i < h.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(h[i]);
                    numberOfBlocks++;
                    continue;
                }

                if (h[i] < stack.Peek())
                {
                    while (stack.Count > 0 && h[i] < stack.Peek())
                    {
                        stack.Pop();
                    }

                    if (stack.Count == 0 || h[i] > stack.Peek())
                    {
                        stack.Push(h[i]);
                        numberOfBlocks++;
                    }                   
                }
                else if(h[i] > stack.Peek())
                {
                    stack.Push(h[i]);
                    numberOfBlocks++;
                }
            }

            return numberOfBlocks;
        }
    }
}
