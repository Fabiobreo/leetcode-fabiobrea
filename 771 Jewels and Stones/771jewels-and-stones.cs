public class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        var set = new HashSet<char>();
        foreach (var letter in jewels)
        {
            set.Add(letter);
        }

        int count = 0;
        foreach (var stone in stones)
        {
            if (set.Contains(stone))
            {
                count++;
            }
        }
        return count;
    }
}