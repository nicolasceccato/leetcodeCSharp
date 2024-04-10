namespace MergeSortedArray;

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int size = m + n;
        
        int i = m;
      
        for (int j = 0; j < n; j++, i++)
        {
            nums1[i] = nums2[j];
        }
        
        orderArray(nums1, size);
        
    }

    private void orderArray(int[] nums, int size)
    {
        for (int i = 0; i < size - 1; i++)
        {
            for (int j = i + 1; j < size; j++)
            {
                if (nums[j] < nums[i])
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }
            }
        }
    }
}