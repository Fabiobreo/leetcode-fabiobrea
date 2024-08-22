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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return SortedArrayToBST(nums, 0, nums.Length - 1);
    }

    private TreeNode SortedArrayToBST(int[] nums, int start, int end) 
    {
        if (end < start)
        {
            return null;
        }

        int mid = (start + end) / 2;
        TreeNode n = new TreeNode(nums[mid]);
        n.left = SortedArrayToBST(nums, start, mid - 1);
        n.right = SortedArrayToBST(nums, mid + 1, end);
        return n;
    }
}