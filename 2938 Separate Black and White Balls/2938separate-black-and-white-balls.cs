public class Solution
{
    public long MinimumSteps(string s)
    {
        int leftIndex = 0;
        long totalSwaps = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == '0')
            {
                totalSwaps += i - leftIndex;
                leftIndex++;
            }
        }
        return totalSwaps;
    }
}