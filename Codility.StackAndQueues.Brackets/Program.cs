using System;

namespace Codility.StackAndQueues.Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var algorithm = new Algorithm();
            algorithm.Solution("{[()()]}");
            algorithm.Solution("([)()]");
            algorithm.Solution("{[()()]}{[()()]}");
        }
    }
}
