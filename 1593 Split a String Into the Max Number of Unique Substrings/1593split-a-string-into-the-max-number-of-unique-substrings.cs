public class Solution
{
    public int MaxUniqueSplit(string s)
    {
        var seen = new HashSet<string>();
        int[] maxCount = new int[1];
        Backtrack(s, 0, seen, 0, maxCount);
        return maxCount[0];
    }

    private void Backtrack(string s, int start, HashSet<string> seen, int count, int[] maxCount)
    {
        if (count + (s.Length - start) <= maxCount[0]) return;
        if (start == s.Length)
        {
            maxCount[0] = Math.Max(maxCount[0], count);
            return;
        }

        for (int end = start + 1; end <= s.Length; ++end)
        {
            var subString = s.Substring(start, end - start);
            if (!seen.Contains(subString))
            {
                seen.Add(subString);
                Backtrack(s, end, seen, count + 1, maxCount);
                seen.Remove(subString);
            }
        }
    }
}