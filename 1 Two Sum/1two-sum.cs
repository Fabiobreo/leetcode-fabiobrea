public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indices = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; ++i)
        {
            int rest = target - nums[i];
            if (indices.ContainsKey(rest))
            {
                return new int[] { indices[rest], i };
            }

            indices[nums[i]] = i;
        }
        return null;
    }
}