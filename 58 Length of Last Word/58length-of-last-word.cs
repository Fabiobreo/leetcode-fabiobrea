public class Solution
{
    public int LengthOfLastWord(string s)
    {
        int length = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                if (length > 0)
                {
                    return length;
                }
            }
            else
            {
                length++;
            }
        }
        return length;
    }
}