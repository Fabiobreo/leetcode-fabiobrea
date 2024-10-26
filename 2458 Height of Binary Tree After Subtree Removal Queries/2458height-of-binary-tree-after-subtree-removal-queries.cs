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
    private int[] maxHeightAfterRemoval = new int[100001];
    private int currentMaxHeight = 0;

    public int[] TreeQueries(TreeNode root, int[] queries)
    {
        TraverseLeftToRight(root, 0);
        currentMaxHeight = 0;
        TraverseRightToLeft(root, 0);
        var results = new int[queries.Length];
        for (int i = 0; i < queries.Length; ++i)
        {
            results[i] = maxHeightAfterRemoval[queries[i]];
        }
        return results;
    }

    private void TraverseLeftToRight(TreeNode root, int currentHeight)
    {
        if (root == null)
        {
            return;
        }
        maxHeightAfterRemoval[root.val] = currentMaxHeight;
        currentMaxHeight = Math.Max(currentMaxHeight, currentHeight);
        TraverseLeftToRight(root.left, currentHeight + 1);
        TraverseLeftToRight(root.right, currentHeight + 1);
    }

    private void TraverseRightToLeft(TreeNode root, int currentHeight)
    {
        if (root == null)
        {
            return;
        }
        maxHeightAfterRemoval[root.val] = Math.Max(maxHeightAfterRemoval[root.val], currentMaxHeight);
        currentMaxHeight = Math.Max(currentMaxHeight, currentHeight);
        TraverseRightToLeft(root.right, currentHeight + 1);
        TraverseRightToLeft(root.left, currentHeight + 1);
    }
}