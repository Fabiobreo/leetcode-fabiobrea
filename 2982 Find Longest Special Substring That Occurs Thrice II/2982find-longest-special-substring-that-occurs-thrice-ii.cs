public class Solution {
    public int MaximumLength(string s)
    {
        int[,] counts = new int[26, s.Length + 1];
        char last = '0';
        int repeatCount = 0;
        foreach (char c in s)
        {
            int index = c - 'a';
            if (c == last)
            {
                repeatCount++;
            }
            else
            {
                last = c;
                repeatCount = 1;
            }
            counts[index, repeatCount]++;
        }

        for (int i = 0; i < 26; i++)
        {
            for (int j = s.Length - 1; j >= 0; j--)
            {
                counts[i, j] += counts[i, j + 1];
            }
        }

        int result = -1;
        for (int i = 0; i < 26; i++)
        {
            int j = 0;
            while (counts[i, j] >= 3) j++;
            result = Math.Max(result, j - 1);
        }
        return result;
    }
}