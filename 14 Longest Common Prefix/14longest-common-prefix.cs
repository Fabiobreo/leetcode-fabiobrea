public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
        {
            return strs[0];
        }

        string prefix = "";
        for (int i = 0; i < strs[0].Length; ++i)
        {
            var current = strs[0][i];
            for (int j = 1; j < strs.Length; ++j)
            {
                if (i == strs[j].Length || strs[j][i] != current)
                {
                    return prefix;
                }
            }
            prefix += current;
        }
        return prefix;
    }
}