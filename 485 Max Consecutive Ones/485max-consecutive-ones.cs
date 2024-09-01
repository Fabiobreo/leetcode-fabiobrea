public class Solution
{
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int max = 0;
        int current = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] == 0)
            {
                current = 0;
            }
            else
            {
                current++;
                max = Math.Max(max, current);
            }
        }
        return max;
    }
}