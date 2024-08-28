public class Solution
{
    public int CountSubIslands(int[][] grid1, int[][] grid2)
    {
        int m = grid1.Length, n = grid1[0].Length;
        int count = 0;
        for (int i = 0; i < m; i++)
            for (int j = 0; j < n; j++)
                if (grid2[i][j] == 1 && dfs(grid1, grid2, i, j))
                    count++;
        return count;
    }

    private bool dfs(int[][] grid1, int[][] grid2, int i, int j) {
        int m = grid1.Length, n = grid1[0].Length;
        if (i < 0 || i >= m || j < 0 || j >= n || grid2[i][j] == 0)
            return true;
        grid2[i][j] = 0;
        bool res = true;
        res &= dfs(grid1, grid2, i + 1, j);
        res &= dfs(grid1, grid2, i - 1, j);
        res &= dfs(grid1, grid2, i, j + 1);
        res &= dfs(grid1, grid2, i, j - 1);
        return res && grid1[i][j] == 1;
    }
}