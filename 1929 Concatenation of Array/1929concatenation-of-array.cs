public class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int n = nums.Length;
        var conc = new int[n * 2];
        for (int i = 0; i < n; ++i)
        {
            conc[i] = nums[i];
            conc[i + n] = nums[i];
        }
        return conc;
    }
}