public class Solution {
    public bool IsIsomorphic(string s, string t) {
        Dictionary<char, char> charMap = new Dictionary<char, char>();
        HashSet<char> usedChars = new HashSet<char>();
        if (s.Length != t.Length)
        {
            return false;
        }

        for (var i = 0; i < s.Length; ++i)
        {
            var sChar = s[i];
            if (!charMap.ContainsKey(sChar))
            {
                if (usedChars.Contains(t[i]))
                {
                    return false;
                }
                charMap.Add(sChar, t[i]);
                usedChars.Add(t[i]);
            }
            else
            {
                if (charMap[sChar] != t[i])
                {
                    return false;
                }
            }
        }
        return true;
    }
}