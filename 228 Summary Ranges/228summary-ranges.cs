public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        List<string> ranges = new();
        for (int i = 0; i < nums.Length; ++i)
        {
            int min = nums[i];
            int j = 0;
            for (; j + i < nums.Length - 1; ++j)
            {
                if (nums[i + j] != (nums[i + j + 1] - 1))
                {
                    break;
                }
            }
            int max = nums[i + j];
            if (min == max)
            {
                ranges.Add(min.ToString());
            }
            else
            {
                ranges.Add($"{min}->{max}");
            }
            i += j;
        }
        return ranges;
    }
}