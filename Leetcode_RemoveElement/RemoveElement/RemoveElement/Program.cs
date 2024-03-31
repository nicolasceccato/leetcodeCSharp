using System;

namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new[] { 3, 2, 2, 3};
            int val = 3;

            int value = solution.RemoveElement(nums, val);

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}