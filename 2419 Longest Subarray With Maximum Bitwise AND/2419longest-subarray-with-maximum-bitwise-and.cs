public class Solution
{
    public int LongestSubarray(int[] nums)
    {
        int maxNum = int.MinValue;
        int maxSubLength = 0;
        int currentSubLength = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (nums[i] > maxNum)
            {
                maxNum = nums[i];
                maxSubLength = 0;
                currentSubLength = 1;
            }
            else if (nums[i] == maxNum)
            {
                currentSubLength++;
            }
            else
            {
                maxSubLength = Math.Max(maxSubLength, currentSubLength);
                currentSubLength = 0;
            }
        }
        maxSubLength = Math.Max(maxSubLength, currentSubLength);
        return maxSubLength;
    }
}