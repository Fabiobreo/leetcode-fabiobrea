public class Solution
{
    public int MinChanges(string s)
    {
        char current = s[0];
        int consecutiveCount = 0;
        int minChangesRequired = 0;

        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] == current)
            {
                consecutiveCount++;
                continue;
            }

            if (consecutiveCount % 2 == 0)
            {
                consecutiveCount = 1;
            }
            else
            {
                consecutiveCount = 0;
                minChangesRequired++;
            }
            current = s[i];
        }
        return minChangesRequired;
    }
}