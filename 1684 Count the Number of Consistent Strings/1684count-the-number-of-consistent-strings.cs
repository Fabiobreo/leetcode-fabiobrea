public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var set = new HashSet<char>(allowed);
        int count = 0;
        foreach (var word in words)
        {
            bool allow = true;
            foreach (var letter in word)
            {
                if (!set.Contains(letter))
                {
                    allow = false;
                    break;
                }
            }

            if (allow)
            {
                count++;
            }
        }
        return count;
    }
}