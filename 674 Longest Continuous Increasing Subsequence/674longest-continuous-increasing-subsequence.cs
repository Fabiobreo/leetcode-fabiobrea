public class Solution {
    public int FindLengthOfLCIS(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 1;
        }

        int maxStreak = 1;
        int currentStreak = 1;
        for (int i = 1; i < nums.Length; ++i)
        {
            if (nums[i] > nums[i - 1])
            {
                currentStreak++;
                maxStreak = Math.Max(maxStreak, currentStreak);
            }
            else
            {
                currentStreak = 1;
            }
        }
        return maxStreak;
    }
}