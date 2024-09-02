public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int firstIndex = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] != 0)
            {
                nums[firstIndex++] = nums[i];
            }
        }

        while (firstIndex < nums.Length)
        {
            nums[firstIndex++] = 0;
        }
    }
}