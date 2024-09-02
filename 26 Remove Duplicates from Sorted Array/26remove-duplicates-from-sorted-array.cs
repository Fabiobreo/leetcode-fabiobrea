public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int count = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            if (i == 0 || nums[i] != nums[count - 1])
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }
}