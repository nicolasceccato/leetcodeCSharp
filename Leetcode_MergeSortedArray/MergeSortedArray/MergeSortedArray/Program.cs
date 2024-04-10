using System;

namespace MergeSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = new int[] { 2, 5, 6 };
            int n = 3;

            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);

            for (int i = 0; i < (m + n); i++)
            {
                Console.WriteLine(nums1[i]);
            }
            
        }
    }
}