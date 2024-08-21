public class Solution
{
    public bool CanJump(int[] nums)
    {
        int length = nums.Length;
        int lastTrueIndex = length - 1;

        for (int i = length - 2; i >=0; i--)
        {
            if (nums[i] >= lastTrueIndex - i)
            {
                lastTrueIndex = i;
            }
        }
        return lastTrueIndex == 0;
    }
}