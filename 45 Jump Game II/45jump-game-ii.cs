public class Solution
{
    public int Jump(int[] nums)
    {
        int n = nums.Length;
        int[] dp = new int[n];
        dp[n - 1] = 0;

        for (int i = n - 2; i >= 0; i--)
        {
            int allowedSteps = nums[i];
            int currentMin = 100000001;
            if (allowedSteps + i >= n - 1)
            {
                currentMin = 0;
            }
            else
            {
                for (int j = 1; j <= allowedSteps; ++j)
                {
                    currentMin = Math.Min(currentMin, dp[i + j]);
                }
            }
            dp[i] = 1 + currentMin;
        }
        return dp[0];
    }
}