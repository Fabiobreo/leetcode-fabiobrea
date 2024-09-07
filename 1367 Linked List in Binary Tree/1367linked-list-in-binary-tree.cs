/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
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
    public bool IsSubPath(ListNode head, TreeNode root)
    {
        if(head == null) return true;
        if(root == null) return false;
        return DFS(head, root) || IsSubPath(head, root.left) || IsSubPath(head, root.right);
    }

    private bool DFS(ListNode head, TreeNode root)
    {
        if (head == null) return true;
        if (root == null) return false;

        return head.val == root.val && (DFS(head.next, root.left) || DFS(head.next, root.right));
    }
}