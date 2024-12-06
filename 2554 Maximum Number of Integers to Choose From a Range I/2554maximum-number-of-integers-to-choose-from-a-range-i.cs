public class Solution
{
    public int MaxCount(int[] banned, int n, int maxSum)
    {
        var map = new HashSet<int>();
        foreach (int num in banned)
        {
            map.Add(num);
        }

        int sum = 0;
        int chosen = 0;
        for (int i = 1; i <= n; ++i)
        {
            if (map.Contains(i))
            {
                continue;
            }

            if (sum + i > maxSum)
            {
                break;
            }
            else
            {
                sum += i;
                chosen++;
            }
        }
        return chosen;
    }
}