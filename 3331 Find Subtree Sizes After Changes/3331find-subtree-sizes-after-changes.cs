public class Solution
{
    private List<int>[] tree;
    
    public int[] FindSubtreeSizes(int[] parent, string s)
    {
        int n = parent.Length;
        tree = new List<int>[n];
        for (int i = 0; i < n; ++i)
        {
            tree[i] = new List<int>();
        }
        
        for (int i = 1; i < n; ++i)
        {
            tree[parent[i]].Add(i);
        }

        var charStacks = new Dictionary<char, Stack<int>>();
        DFS(0, parent, s, charStacks);
        var newTree = new List<int>[n];
        for (int i = 0; i < n; ++i)
        {
            newTree[i] = new List<int>();
        }
        
        for (int i = 1; i < n; ++i)
        {
            newTree[parent[i]].Add(i);
        }

        int[] sizes = new int[n];
        ComputeSubtreeSizes(0, newTree, sizes);
        return sizes;
    }

    private void DFS(int node, int[] parent, string s, Dictionary<char, Stack<int>> charStacks)
    {
        char currentChar = s[node];
        if (!charStacks.TryGetValue(currentChar, out var stack))
        {
            stack = new Stack<int>();
            charStacks[currentChar] = stack;
        }

        if (stack.Count > 0)
        {
            parent[node] = stack.Peek();
        }
        stack.Push(node);
        foreach (var child in tree[node])
        {
            DFS(child, parent, s, charStacks);
        }
        stack.Pop();
        if (stack.Count == 0)
        {
            charStacks.Remove(currentChar);
        }
    }

    private int ComputeSubtreeSizes(int node, List<int>[] tree, int[] sizes)
    {
        int size = 1;
        foreach (int child in tree[node])
        {
            size += ComputeSubtreeSizes(child, tree, sizes);
        }
        sizes[node] = size;
        return size;
    }
}