public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int currMax = 0;
        int maxTillNow = int.MinValue;
        foreach (var c in nums)
        {
            currMax = Math.Max(c, currMax + c);
            maxTillNow = Math.Max(maxTillNow, currMax);
        }
        return maxTillNow;
    }
}