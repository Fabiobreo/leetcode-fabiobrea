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
public class Solution {
    public int MaxDepth(TreeNode root) {
        return MaxDepth(root, 0);
    }

    private int MaxDepth(TreeNode root, int currentHeight)
    {
        if (root == null)
        {
            return currentHeight;
        }
        int leftHeight = MaxDepth(root.left, currentHeight + 1);
        int rightHeight = MaxDepth(root.right, currentHeight + 1);
        return Math.Max(leftHeight, rightHeight);
    }
}