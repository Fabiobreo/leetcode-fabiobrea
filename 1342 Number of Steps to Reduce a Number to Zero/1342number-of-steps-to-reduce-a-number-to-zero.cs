public class Solution {
    public int NumberOfSteps(int num)
    {
        int res = 0;
        while (num > 0)
        {
            if (num > 1 && (num & 1) == 1) {
                res++;
            }
            num = num >> 1;
            res++;
        }
        return res;
    }
}