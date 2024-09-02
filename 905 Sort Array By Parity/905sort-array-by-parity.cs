public class Solution
{
    public int[] SortArrayByParity(int[] nums)
    {
        int lowPointer = 0;
        while (lowPointer < nums.Length && nums[lowPointer] % 2 == 0)
        {
            lowPointer++;
        }

        int highPointer = nums.Length - 1;
        while (highPointer >= 0 && nums[highPointer] % 2 == 1)
        {
            highPointer--;
        }

        while (lowPointer < highPointer)
        {
            if (nums[lowPointer] % 2 == 1)
            {
                (nums[lowPointer], nums[highPointer]) = (nums[highPointer], nums[lowPointer]);
                highPointer--;
            }
            else
            {
                lowPointer++;
            }
        }
        return nums;
    }
}