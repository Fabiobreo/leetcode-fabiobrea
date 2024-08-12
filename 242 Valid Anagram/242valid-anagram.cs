public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> freq = new Dictionary<char, int>();
        if (s.Length != t.Length)
        {
            return false;
        }

        for (int i = 0; i < s.Length; ++i)
        {
            if (!freq.ContainsKey(s[i]))
            {
                freq.Add(s[i], 0);
            }
            freq[s[i]]++;

            if (!freq.ContainsKey(t[i]))
            {
                freq.Add(t[i], 0);
            }
            freq[t[i]]--;
        }
        return !freq.Any(pair => pair.Value != 0);
    }
}