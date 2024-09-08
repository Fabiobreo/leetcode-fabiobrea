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
    public ListNode[] SplitListToParts(ListNode head, int k)
    {
        int count = 0;
        ListNode it = head;
        while (it != null)
        {
            count++;
            it = it.next;
        }
        int minElements = count / k;
        int rest = count % k;

        ListNode[] splittedList = new ListNode[k];
        it = head;
        for (int i = 0; i < k; i++)
        {
            splittedList[i] = it;
            int currentSize = minElements + (i < rest ? 1 : 0);
            
            for (int j = 0; j < currentSize - 1 && it != null; j++)
            {
                it = it.next;
            }
            
            if (it != null)
            {
                ListNode temp = it.next;
                it.next = null;
                it = temp;
            }
        }
        return splittedList;
    }
}