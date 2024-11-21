public class Solution
{
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls)
    {
        int[,] matrix = new int[m, n];
        foreach (var g in guards)
        {
            matrix[g[0], g[1]] = 2;
        }

        foreach (var w in walls)
        {
            matrix[w[0], w[1]] = 2;
        }

        int[] dirs = new int[] {-1, 0, 1, 0, -1};

        foreach (var guard in guards)
        {
            for (int i = 0; i < 4; i++)
            {
                int x = guard[0];
                int y = guard[1];
                int dx = dirs[i];
                int dy = dirs[i + 1];

                while (x + dx >= 0 && x + dx < m &&
                    y + dy >= 0 && y + dy < n &&
                    matrix[x + dx, y + dy] < 2)
                {
                    x += dx;
                    y += dy;
                    matrix[x, y] = 1;
                }
            }
        }

        int unguarded = 0;
        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if (matrix[i, j] == 0)
                {
                    unguarded++;
                }
            }
        }
        return unguarded;
    }
}