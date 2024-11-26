public class Solution
{
    public int FindChampion(int n, int[][] edges)
    {
        int[] ingoing = new int[n];
        foreach (var edge in edges)
        {
            ingoing[edge[1]]++;
        }

        int value = -1;
        for (int i = 0; i < n; ++i)
        {
            if (ingoing[i] == 0)
            {
                if (value == -1)
                {
                    value = i;
                }
                else
                {
                    return -1;
                }
            }
        }
        return value;
    }
}