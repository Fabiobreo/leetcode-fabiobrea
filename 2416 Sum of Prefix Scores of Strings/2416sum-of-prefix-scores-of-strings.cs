public class Solution
{
    class TrieNode
    {
        public TrieNode[] Next = new TrieNode[26];
        public int Count = 0;
    }

    TrieNode root = new TrieNode();

    public int[] SumPrefixScores(string[] words)
    {
        for (int i = 0; i < words.Length; ++i)
        {
            InsertWord(words[i]);
        }

        int[] scores = new int[words.Length];
        for (int i = 0; i < words.Length; ++i)
        {
            scores[i] = GetScore(words[i]);
        }
        return scores;
    }

    private void InsertWord(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            if (node.Next[c - 'a'] == null)
            {
                node.Next[c- 'a'] = new TrieNode();
            }
            node.Next[c- 'a'].Count++;
            node = node.Next[c- 'a'];
        }
    }

    private int GetScore(string s)
    {
        TrieNode node = root;
        int result = 0;
        foreach (char c in s)
        {
            result += node.Next[c - 'a'].Count;
            node = node.Next[c - 'a'];
        }
        return result;
    }
}