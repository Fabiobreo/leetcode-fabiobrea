public class Solution
{
    public string ShortestPalindrome(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            return s;
        }

        int n = s.Length;
        int end = n - 1;
        int j = 0;

        while (end >= 0)
        {
            if (s[end] == s[j])
            {
                j++;
            }
            end--;
        }

        if (j == n)
        {
            return s;
        }

        string suffix = s.Substring(j);
        string reversed = Reverse(suffix);
        return reversed + ShortestPalindrome(s.Substring(0, j)) + suffix;
    }

    private string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}