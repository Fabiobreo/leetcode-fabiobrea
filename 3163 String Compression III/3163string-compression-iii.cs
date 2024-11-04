public class Solution
{
    public string CompressedString(string word)
    {
        var comp = new StringBuilder();
        int times = 1;
        char lastChar = word[0];
        for (int i = 1; i < word.Length; ++i)
        {
            if (word[i] != lastChar || times == 9)
            {
                comp.Append($"{times}{lastChar}");
                lastChar = word[i];
                times = 1;
            }
            else
            {
                times++;
            }
        }
        comp.Append($"{times}{lastChar}");
        return comp.ToString();
    }
}