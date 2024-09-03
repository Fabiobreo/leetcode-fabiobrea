/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public IList<TreeNode> FindDuplicateSubtrees(TreeNode root)
    {
        var comparer = new TreeNodeComparer();
        var uniques = new HashSet<TreeNode>(comparer);
        var duplicates = new HashSet<TreeNode>(comparer);
        var nodes = new Stack<TreeNode>();

        nodes.Push(root);
        while (nodes.Any())
        {
            var node = nodes.Pop();
            if (!uniques.Add(node))
            {
                duplicates.Add(node);
            }

            if (node.left != null)
            {
                nodes.Push(node.left);
            }

            if (node.right != null)
            {
                nodes.Push(node.right);
            }
        }

        return duplicates.ToList();
    }

    private class TreeNodeComparer : IEqualityComparer<TreeNode>
    {
        private Dictionary<TreeNode, int> hashCodes = new();

        public int GetHashCode(TreeNode node)
        {
            if (node == null)
            {
                return 0;
            }

            if (!hashCodes.ContainsKey(node))
            {
                var left = GetHashCode(node.left);
                var right = GetHashCode(node.right);
                var hashCode = (node.val, left, right).GetHashCode();
                hashCodes[node] = hashCode;
            }

            return hashCodes[node];
        }

        public bool Equals(TreeNode node1, TreeNode node2)
        {
            return (node1, node2) switch
            {
                (null, null) => true,
                (null, _) or (_, null) => false,
                _ => node1.val == node2.val &&
                    Equals(node1.left, node2.left) &&
                    Equals(node1.right, node2.right),
            };
        }
    }
}