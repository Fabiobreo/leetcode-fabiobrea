public class Solution {
    public int MajorityElement(int[] nums) {
        int major = 0;
        int count = 0;
        foreach (int num in nums)
        {
            if (count == 0)
            {
                major = num;
                count++;
            }
            else
            {
                if (num == major)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }
        }
        return major;
    }
}