public class Solution
{
    public long MinimumTotalDistance(IList<int> robot, int[][] factory)
    {
        var robots = robot.ToList();
        var factories = factory.ToList();
        robots.Sort();
        factories.Sort((a, b) => a[0].CompareTo(b[0]));

        int m = robots.Count;
        int n = factories.Count;

        long[,] dp = new long[m + 1, n + 1];
        for (int i = 0; i < m; i++)
        {
            dp[i, n] = long.MaxValue;
        }

        for (int j = n - 1; j >= 0; j--)
        {
            long prefix = 0;
            var linkedList = new LinkedList<(int pos, long val)>();
            linkedList.AddLast((m, 0));

            for (int i = m - 1; i >= 0; i--)
            {
                prefix += Math.Abs((long)robots[i] - factories[j][0]);
                while (linkedList.Count > 0 && linkedList.First.Value.pos > i + factories[j][1])
                {
                    linkedList.RemoveFirst();
                }
                while (linkedList.Count > 0 && linkedList.Last.Value.val >= dp[i, j + 1] - prefix) {
                    linkedList.RemoveLast();
                }
                linkedList.AddLast((i, dp[i, j + 1] - prefix));
                dp[i, j] = linkedList.First.Value.val + prefix;
            }
        }
        return dp[0, 0];
    }
}