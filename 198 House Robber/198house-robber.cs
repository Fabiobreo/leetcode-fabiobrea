public class Solution
{
    public int Rob(int[] nums)
    {
        int n = nums.Length;
        if (n == 1)
        {
            return nums[0];
        }
        int[] dp = new int[n];
        dp[n - 1] = nums[n - 1];
        dp[n - 2] = nums[n - 2];
        for (int i = n - 3; i >= 0; --i)
        {
            dp[i] = nums[i] + Math.Max(dp[i + 2], i + 3 < n ? dp[i + 3] : 0);
        }

        var maxRob = Math.Max(dp[0], dp[1]);

        return maxRob;
    }
}