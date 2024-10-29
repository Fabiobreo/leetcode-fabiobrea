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
    public TreeNode TrimBST(TreeNode root, int low, int high)
    {
        if (root == null)
        {
            return null;
        }

        while (root != null && (root.val < low || root.val > high))
        {
            if (root.val < low)
            {
                root = root.right;
            }
            else if (root.val > high)
            {
                root = root.left;
            }
        }

        if (root == null)
        {
            return null;
        }

        var leftChild = TrimBST(root.left, low, high);
        var rightChild = TrimBST(root.right, low, high);
        root.left = leftChild;
        root.right = rightChild;
        return root;
    }
}