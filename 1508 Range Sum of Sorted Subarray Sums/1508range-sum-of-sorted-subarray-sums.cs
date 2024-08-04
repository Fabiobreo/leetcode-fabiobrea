public class Solution {
    public int RangeSum(int[] nums, int n, int left, int right) {
        List<int> sums = new List<int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            int sum = nums[i];
            sums.Add(sum);

            for (int j = i + 1; j < nums.Length; ++j)
            {
                sum += nums[j];
                sums.Add(sum);
            }
        }

        sums.Sort();
        long result = 0;
        for (int i = left - 1; i < right; ++i)
        {
            result += sums[i];
        }
        return (int)(result % (Math.Pow(10, 9) + 7));
    }
}