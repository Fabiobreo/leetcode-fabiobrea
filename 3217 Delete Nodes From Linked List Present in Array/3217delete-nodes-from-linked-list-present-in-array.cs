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
public class Solution
{
    public ListNode ModifiedList(int[] nums, ListNode head)
    {
        var set = new HashSet<int>(nums);
        while (head != null)
        {
            if (set.Contains(head.val))
            {
                head = head.next;
            }
            else
            {
                break;
            }
        }

        ListNode baseNode = head;
        ListNode searcher = head.next;
        while (searcher != null)
        {
            if (set.Contains(searcher.val))
            {
                searcher = searcher.next;
                if (searcher == null)
                {
                    baseNode.next = searcher;
                }
                continue;
            }
            baseNode.next = searcher;
            baseNode = searcher;
            searcher = searcher.next;
        }
        return head;
    }
}