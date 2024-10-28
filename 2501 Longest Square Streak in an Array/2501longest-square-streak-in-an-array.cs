public class Solution
{
    public int LongestSquareStreak(int[] nums)
    {
        var set = new HashSet<int>();
        foreach (var num in nums)
        {
            set.Add(num);
        }

        int longestStreak = 0;
        foreach (var num in set)
        {
            int currentStreak = 0;
            long curr = num;
            while (set.Contains((int)curr))
            {
                currentStreak++;
                if (curr * curr > 1e5)
                {
                    break;
                }
                curr *= curr;
            }
            longestStreak = Math.Max(longestStreak, currentStreak);
        }

        return longestStreak < 2 ? -1 : longestStreak;
    }
}