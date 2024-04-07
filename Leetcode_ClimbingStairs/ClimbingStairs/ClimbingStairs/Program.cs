using System;

namespace ClimbingStairs // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine(solution.ClimbStairs(5));
        }
    }
}