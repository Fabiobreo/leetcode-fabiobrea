public class Solution
{
    public int CountPrefixSuffixPairs(string[] words)
    {
        int n = words.Length;
        int count = 0;

        for (int i = 0; i < n - 1; ++i)
        {
            for (int j = i + 1; j < n; ++j)
            {
                var str1 = words[i];
                var str2 = words[j];
                if (str1.Length > str2.Length)
                {
                    continue;
                }

                if (str2.StartsWith(str1) && str2.EndsWith(str1))
                {
                    ++count;
                }
            }
        }
        return count;
    }
}