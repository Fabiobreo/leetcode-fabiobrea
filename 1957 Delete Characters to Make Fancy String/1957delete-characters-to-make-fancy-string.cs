public class Solution
{
    public string MakeFancyString(string s)
    {
        StringBuilder b = new StringBuilder(s.Length);
        var lastChar = s[0];
        int count = 0;
        foreach (var c in s)
        {
            if (c == lastChar)
            {
                count++;
            }
            else
            {
                lastChar = c;
                count = 1;
            }

            if (count < 3)
            {
                b.Append(c);
            }
        }
        return b.ToString();
    }
}