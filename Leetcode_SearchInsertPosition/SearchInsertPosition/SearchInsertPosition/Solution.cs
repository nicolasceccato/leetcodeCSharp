namespace SearchInsertPosition;

public class Solution {
    public int SearchInsert(int[] nums, int target)
    {
        int index = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < target)
            {
                index++;
            }

            if (nums[i] == target)
            {
                return i;
            }
        }

        return index;
    }
}