public class Solution {
    public int FirstUniqChar(string s)
    {
        var dict = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; ++i)
        {
            if (!dict.ContainsKey(s[i]))
            {
                dict.Add(s[i], i);
            }
            else
            {
                dict[s[i]] = -1;
            }
        }

        int minIndex = int.MaxValue;
        foreach (var key in dict.Keys)
        {
            if (dict[key] != -1)
            {
                minIndex = Math.Min(minIndex, dict[key]);
            }
        }
        return minIndex != int.MaxValue ? minIndex : -1;
    }
}