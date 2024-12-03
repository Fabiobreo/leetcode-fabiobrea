public class Solution {
    public string AddSpaces(string s, int[] spaces)
    {
        var builder = new StringBuilder(s.Length + spaces.Length);
        int i = 0;
        int j = 0;
        while (i < s.Length)
        {
            if (j < spaces.Length && i == spaces[j])
            {
                builder.Append(" ");
                j++;
            }
            else
            {
                builder.Append(s[i]);
                i++;
            }
        }
        return builder.ToString();
    }
}