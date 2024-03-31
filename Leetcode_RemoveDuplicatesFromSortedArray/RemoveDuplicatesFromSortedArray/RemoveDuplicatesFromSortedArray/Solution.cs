namespace RemoveDuplicatesFromSortedArray;

public class Solution
{

    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }
        
        int index = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[index] != nums[i])
            {
                index++;
                nums[index] = nums[i];
            }
        }

        return index + 1;

    }
}

