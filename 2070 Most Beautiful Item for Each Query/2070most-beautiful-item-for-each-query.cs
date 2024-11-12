public class Solution
{
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {
        Array.Sort(items, (a, b) => 
        {
            if (a[0] == b[0]) return b[1].CompareTo(a[1]);
            return a[0].CompareTo(b[0]);
        });

        List<int[]> maxBeauty = new List<int[]>();
        int currentMaxBeauty = 0;

        foreach (var item in items)
        {
            currentMaxBeauty = Math.Max(currentMaxBeauty, item[1]);
            maxBeauty.Add(new int[] { item[0], currentMaxBeauty });
        }

        int[] result = new int[queries.Length];
        for (int i = 0; i < queries.Length; ++i)
        {
            int query = queries[i];
            int left = 0;
            int right = maxBeauty.Count - 1;
            int answer = 0;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (maxBeauty[mid][0] <= query)
                {
                    answer = maxBeauty[mid][1];
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            result[i] = answer;
        }
        return result;
    }
}