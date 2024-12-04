public class Solution
{
    public bool CanMakeSubsequence(string str1, string str2)
    {
        int i = 0;
        foreach (var letter in str1)
        {
            if (i == str2.Length)
            {
                break;
            }
            int first = letter - 'a';
            int second = str2[i] - 'a';
            if (first == second || (first + 1) % 26 == second)
            {
                ++i;
            }
        }
        return i == str2.Length;
    }
}