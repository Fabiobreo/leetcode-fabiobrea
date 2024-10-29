public class Solution
{
    public int MaxMoves(int[][] grid)
    {
        if (grid.Length == 0)
        {
            return 0;
        }

        int[][] dp = new int[grid.Length][];
        int rows = grid.Length;
        int cols = grid[0].Length;
        for (int i = 0; i < rows; ++i)
        {
            dp[i] = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                dp[i][j] = -1;
                if (j == cols - 1)
                {
                    dp[i][j] = 0;
                }
            }
        }

        for (int i = cols - 2; i >= 0; --i)
        {
            for (int j = 0; j < rows; j++)
            {
                if (j > 0 && grid[j][i] < grid[j - 1][i + 1])
                {
                    dp[j][i] = Math.Max(dp[j][i], dp[j - 1][i + 1]);
                } 

                if (grid[j][i] < grid[j][i + 1])
                {
                    dp[j][i] = Math.Max(dp[j][i], dp[j][i + 1]);
                }

                if (j < rows - 1 && grid[j][i] < grid[j + 1][i + 1])
                {
                    dp[j][i] = Math.Max(dp[j][i], dp[j + 1][i + 1]);
                }
                dp[j][i]++;
            }
        }

        int max = 0;
        for (int i = 0; i < rows; ++i)
        {
            max = Math.Max(max, dp[i][0]);
        }
        return max;
    }
}