using System;

namespace SearchInsertPosition // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new[] { 1, 3, 5, 6 };
            int target = 5;
            Solution solution = new Solution();
            Console.WriteLine(solution.SearchInsert(nums, target));
            
        }
    }
}