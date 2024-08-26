/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution
{
    public IList<int> Postorder(Node root)
    {
        List<int> order = new List<int>();
        if (root == null)
        {
            return order;
        }

        foreach (var child in root.children)
        {
            order.AddRange(Postorder(child));
        }
        order.Add(root.val);
        return order;
    }
}