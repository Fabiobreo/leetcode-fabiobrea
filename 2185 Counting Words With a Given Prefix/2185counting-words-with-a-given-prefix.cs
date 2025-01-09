public class Solution
{
    public int PrefixCount(string[] words, string pref)
    {
        int answer = 0;
        foreach (var word in words)
        {
            if (word.StartsWith(pref))
            {
                answer++;
            }
        }
        return answer;
    }
}