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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int carry = 0;
        ListNode firstNode = null;
        ListNode currentNode = null;
        while (l1 != null || l2 != null || carry != 0)
        {
            var l1Data = l1 != null ? l1.val : 0;
            var l2Data = l2 != null ? l2.val : 0;

            var sum = l1Data + l2Data + carry; 

            int remainder;
            var quotient = Math.DivRem(sum, 10, out remainder);
            carry = quotient;
            var newNode = new ListNode(remainder);
            if (firstNode == null)
            {
                firstNode = newNode;
                currentNode = newNode;
            }
            else
            {
                currentNode.next = newNode;
                currentNode = currentNode.next;
            }

            l1 = l1?.next;
            l2 = l2?.next;
        }
        return firstNode;
    }
}