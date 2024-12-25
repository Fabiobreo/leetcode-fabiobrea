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
    public IList<int> LargestValues(TreeNode root)
    {
        if (root == null)
        {
            return new List<int>();
        }

        var result = new List<int>();
        Stack<(TreeNode Node, int Depth)> stack = new ();
        stack.Push((root, 0));

        while (stack.Count > 0)
        {
            var pair = stack.Pop();
            var node = pair.Node;
            var depth = pair.Depth;

            if (depth == result.Count)
            {
                result.Add(node.val);
            }
            else
            {
                result[depth] = Math.Max(result[depth], node.val);
            }

            if (node.left != null)
            {
                stack.Push((node.left, depth + 1));
            }
            if (node.right != null)
            {
                stack.Push((node.right, depth + 1));
            }
        }
        return result;
    }
}