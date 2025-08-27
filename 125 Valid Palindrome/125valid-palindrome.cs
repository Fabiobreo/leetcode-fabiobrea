using System.Text.RegularExpressions;
public class Solution {
    public bool IsPalindrome(string s) {
        Regex rgx = new Regex("[^a-zA-Z0-9]");
        s = rgx.Replace(s, "");
        s = s.ToLower();
        for (int i = 0; i < s.Length; ++i)
        {
            if (s[i] != s[s.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}