public class Solution
{
    public int MinExtraChar(string s, string[] dictionary)
    {
        var dict = new HashSet<string>(dictionary);
        var memo = new Dictionary<int, int>();
        return MinExtraCharHelper(s, dict, 0, memo);
    }

    private int MinExtraCharHelper(string s, HashSet<string> dict, int start, Dictionary<int, int> memo)
    {
        if (start == s.Length)
        {
            return 0;
        }

        if (memo.ContainsKey(start))
        {
            return memo[start];
        }

        int minExtra = s.Length - start;
        for (int end = start + 1; end <= s.Length; ++end)
        {
            string sub = s.Substring(start, end - start);
            if (dict.Contains(sub))
            {
                minExtra = Math.Min(minExtra, MinExtraCharHelper(s, dict, end, memo));
            }
            else
            {
                minExtra = Math.Min(minExtra, (end - start) + MinExtraCharHelper(s, dict, end, memo));
            }
        }

        memo[start] = minExtra;
        return minExtra;
    }
}