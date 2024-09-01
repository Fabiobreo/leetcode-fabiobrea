public class Solution
{
    public int FindNumbers(int[] nums)
    {
        int res = 0;
        foreach (var num in nums)
        {
            int digits = 0;
            int tmp = num;
            while (tmp > 0)
            {
                tmp /= 10;
                digits++;
            }

            if (digits % 2 == 0)
            {
                res++;
            }
        }
        return res;
    }
}