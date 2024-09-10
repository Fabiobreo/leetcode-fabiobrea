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
public class Solution {
    public ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        ListNode first = head;
        ListNode second = head.next;
        while (second != null)
        {
            var gcd = CalculateGcd(first.val, second.val);
            var newNode = new ListNode(gcd, second);
            first.next = newNode;
            first = newNode.next;
            second = second.next;
        }
        return head;
    }

    private int CalculateGcd(int first, int second)
    {
        int rest;
        while (second != 0)
        {
            rest = first % second;
            first = second;
            second = rest;
        }
        return first;
    }
}