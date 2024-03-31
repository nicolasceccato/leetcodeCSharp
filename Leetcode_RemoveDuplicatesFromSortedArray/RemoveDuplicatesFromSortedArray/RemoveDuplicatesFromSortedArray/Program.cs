using System;

namespace RemoveDuplicatesFromSortedArray 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[] nums = new[] { 1, 1, 2 };
            int nums2 = solution.RemoveDuplicates(nums);

            for (int i = 0; i < nums2; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}