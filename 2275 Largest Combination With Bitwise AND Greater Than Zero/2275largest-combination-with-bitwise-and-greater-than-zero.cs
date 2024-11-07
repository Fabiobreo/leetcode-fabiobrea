public class Solution
{
    public int LargestCombination(int[] candidates)
    {
        int maxCount = 0;
        for (int i = 0; i < 24; ++i)
        {
            int count = 0;
            var mask = 1 << i;
            foreach (var num in candidates)
            {
                if ((num & mask) != 0)
                {
                    count++;
                }
            }
            maxCount = Math.Max(maxCount, count);
        }
        return maxCount;
    }
}