public class Solution
{
    public int MinimumLength(string s)
    {
        int[] freq = new int[26];
        int totalLength = 0;
        foreach (char c in s)
        {
            freq[c - 'a']++;
        }

        foreach (int frequency in freq)
        {
            if (frequency == 0) continue;
            if (frequency % 2 == 0)
            {
                totalLength += 2;
            }
            else
            {
                totalLength += 1;
            }
        }

        return totalLength;
    }
}