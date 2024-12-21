public class Solution {
    public int MaxKDivisibleComponents(int n, int[][] edges, int[] values, int k)
    {
        List<int>[] g = new List<int>[n];
        foreach(var edge in edges)
        {
            int u = edge[0], v = edge[1];
            if(g[u]==null) g[u] = new();
            if(g[v]==null) g[v] = new();
            g[u].Add(v);
            g[v].Add(u);
        }
        int countKDivisbleConnectedComponents  = 0;
        DFS(0,-1);
        return countKDivisbleConnectedComponents;
        
        long DFS(int cur, int parent)
        {
            long sum = values[cur];
            if(g[cur]!=null)
                foreach(var adj in g[cur])
                    if(adj!=parent)
                        sum+=DFS(adj,cur);
            
            if(sum%k==0)
                countKDivisbleConnectedComponents ++;
            
            return sum;
        }
    }
}