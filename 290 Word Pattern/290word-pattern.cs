public class Solution {
    public bool WordPattern(string pattern, string s) {
        Dictionary<char, string> map = new Dictionary<char, string>();
        HashSet<string> usedWords = new HashSet<string>();
        var words = s.Split(" ");
        int currentIndex = 0;

        if (words.Length != pattern.Length)
        {
            return false;
        }

        foreach (var word in words)
        {
            if (!map.ContainsKey(pattern[currentIndex]))
            {
                if (usedWords.Contains(word))
                {
                    return false;
                }
                map.Add(pattern[currentIndex], word);
                usedWords.Add(word);
            }
            else
            {
                if (map[pattern[currentIndex]] != word)
                {
                    return false;
                }
            }
            currentIndex++;
        }
        return true;
    }
}