public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int lastId = nums.Length - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                return i;
            }
        }
        if (target < nums[0])
            return 0;
        if (target > nums[lastId])
            return lastId + 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (target > nums[i])
            {
                if (target < nums[i + 1])
                    return i + 1;
            }
        }
        return 0;
    }
}