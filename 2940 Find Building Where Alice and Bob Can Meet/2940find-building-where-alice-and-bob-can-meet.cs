public class Solution {
    public int[] LeftmostBuildingQueries(int[] heights, int[][] queries)
    {
        int n = heights.Length;
        int q = queries.Length;
        int[] result = new int[q];
        for (int i = 0; i < q; ++i)
        {
            result[i] = -1;
        }
        
        var deferred = new List<List<int[]>>();
        for (int i = 0; i < n; i++)
        {
            deferred.Add(new List<int[]>());
        }

        var pq = new PriorityQueue<int[], int>();

        for (int i = 0; i < q; ++i)
        {
            int a = queries[i][0];
            int b = queries[i][1];
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            if (a == b || heights[a] < heights[b])
            {
                result[i] = b;
            }
            else
            {
                deferred[b].Add(new int[] { heights[a], i });
            }
        }

        for (int i = 0; i < n; ++i)
        {
            foreach (var query in deferred[i])
            {
                pq.Enqueue(query, query[0]); 
            }
            while (pq.Count > 0 && pq.Peek()[0] < heights[i])
            {
                var current = pq.Dequeue();
                result[current[1]] = i;
            }
        }

        return result;
    }
}