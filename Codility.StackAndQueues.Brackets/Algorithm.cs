using System;
using System.Collections.Generic;

namespace Codility.StackAndQueues.Brackets
{
    public class Algorithm
    {
        public int Solution(string s)
        {
            if (s.Length == 0)
            {
                Console.WriteLine($"String {s} is properly nested.");
                return 1;
            }

            var stack = new Stack<char>();
            foreach (var currentLetter in s)
            {
                if (currentLetter == '(' || currentLetter == '{' || currentLetter == '[')
                {
                    stack.Push(currentLetter);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return 0;
                    }

                    var popedLetter = stack.Pop();
                    if (popedLetter == '(' && currentLetter != ')' || popedLetter == '{' && currentLetter != '}' || popedLetter == '[' && currentLetter != ']')
                    {
                        Console.WriteLine($"String {s} is not properly nested.");
                        return 0;
                    }
                }
            }

            Console.WriteLine($"String {s} is properly nested.");
            return stack.Count == 0 ? 1 : 0;
        }        
    }
}
