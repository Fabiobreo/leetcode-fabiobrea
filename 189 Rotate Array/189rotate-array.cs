public class Solution {
    public void Rotate(int[] nums, int k) {
        k = k % nums.Length;
        int pivot = nums.Length - k;
        Rotate(nums, 0, pivot);
        Rotate(nums, pivot, nums.Length);
        Rotate(nums, 0, nums.Length);
    }

    private void Rotate(int[] nums, int first, int last)
    {
        for (int i = first; i < (first + last) / 2; ++i)
        {
            int tmp = nums[i];
            nums[i] = nums[last - 1 - i + first];
            nums[last - 1 - i + first] = tmp;
        }
    }
}