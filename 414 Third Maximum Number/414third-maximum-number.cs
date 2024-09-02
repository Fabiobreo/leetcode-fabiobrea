public class Solution
{
    public int ThirdMax(int[] nums)
    {
        (int max1, int? max2, int? max3) = (nums[0], null, null);
        for (int index = 1; index < nums.Length; index++)
        {
            int num = nums[index];
            if (max1 == num || max2 == num || max3 == num) continue;

            if (max1 > num is false) (max1, max2, max3) = (num, max1, max2);
            else if (max2 > num is false) (max2, max3) = (num, max2);
            else if (max3 > num is false) max3 = num;
        }

        return max3 ?? max1;
    }
}