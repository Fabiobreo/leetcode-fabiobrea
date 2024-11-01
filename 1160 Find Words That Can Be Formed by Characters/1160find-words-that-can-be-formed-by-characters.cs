public class Solution
{
    public int CountCharacters(string[] words, string chars)
    {
        int[] counts = new int[26];
        foreach (var let in chars)
        {
            counts[let - 'a']++;
        }

        int goodStrings = 0;
        foreach (var word in words)
        {
            int[] wordFreq = new int[26];
            foreach (var let in word)
            {
                wordFreq[let - 'a']++;
            }

            bool good = true;
            for (int i = 0; i < 26; ++i)
            {
                if (counts[i] < wordFreq[i])
                {
                    good = false;
                    break;
                }
            }

            if (good)
            {
                goodStrings += word.Length;
            }
        }
        return goodStrings;
    }
}