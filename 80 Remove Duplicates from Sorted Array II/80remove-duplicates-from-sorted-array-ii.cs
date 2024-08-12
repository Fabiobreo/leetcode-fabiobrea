public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i = 0;
        foreach (var n in nums)
        {
            if (i == 0 || i == 1 || nums[i-2] != n)
            {
                nums[i] = n;
                i++;
            }
        }
        return i;
    }
}