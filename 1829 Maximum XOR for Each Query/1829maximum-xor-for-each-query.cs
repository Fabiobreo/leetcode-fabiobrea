public class Solution
{
    public int[] GetMaximumXor(int[] nums, int maximumBit)
    {
        int[] answers = new int[nums.Length];
        int mask = (1 << maximumBit) - 1;
        int xor = 0;
        for (int i = 0; i < nums.Length; ++i)
        {
            xor = xor ^ nums[i];
            answers[nums.Length - 1 - i] = xor ^ mask;
        }
        return answers;
    }
}