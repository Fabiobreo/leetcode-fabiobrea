public class Solution 
{
    public void DuplicateZeros(int[] nums)
    {
        var n = 10;
        var l = nums.Length;
        var zeroes = 0;

        for(int i = 0; i < l; i++)
        {
            var old = nums[i] % n;

            if(old == 0) 
            {
                zeroes++;
            } 
            else 
            {
                if(i + zeroes < l) 
                {
                    nums[i + zeroes] += old * n;
                }
            }
        }

        for(int i = 0; i < l; i++)
        {
            nums[i] = nums[i] / n;
        }
    }
}