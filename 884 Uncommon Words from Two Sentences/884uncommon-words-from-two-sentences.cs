public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        string combined = s1 + " " + s2;
        string[] words = combined.Split(' ');
        var wordGroups = words.GroupBy(w => w).Where(g => g.Count() == 1).Select(g => g.Key);

        return wordGroups.ToArray();
    }
}