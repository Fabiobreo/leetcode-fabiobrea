public class Solution {
    public int MaxScore(int n, int k, int[][] stayScore, int[][] travelScore)
    {
        long[] previousDay = new long[n];
        long[] currentDay = new long[n];
        for (int i = 0; i < n; ++i)
        {
            var stayOpt = stayScore[0][i];
            var moveOpt = 0L;
            for (int j = 0; j < n; j++)
            {
                if (j == i) continue;
                moveOpt = Math.Max(moveOpt, (long)travelScore[j][i]);
            }
            previousDay[i] = Math.Max(stayOpt, moveOpt);
        }

        for (int day = 1; day < k; ++day)
        {
            for (int i = 0; i < n; ++i)
            {
                var stayOpt = previousDay[i] + stayScore[day][i];
                long moveOpt = 0;
                for (int j = 0; j < n; ++j)
                {
                    if (j == i) continue;
                    moveOpt = Math.Max(moveOpt, previousDay[j] + travelScore[j][i]);
                }
                currentDay[i] = Math.Max(stayOpt, moveOpt);
            }
            previousDay = (long[])currentDay.Clone();
        }

        long maxPoints = 0;
        for (int i = 0; i < n; ++i)
        {
            if (previousDay[i] > maxPoints)
            {
                maxPoints = previousDay[i];
            }
        }
        return (int)maxPoints;
    }
}