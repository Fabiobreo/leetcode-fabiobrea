/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution
{
    public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
    {
        var tempA = headA;
        var tempB = headB;
        int lengthA = 1;
        int lengthB = 1;

        while (tempA.next != null)
        {
            lengthA++;
            tempA = tempA.next;
        }

        while (tempB.next != null)
        {
            lengthB++;
            tempB = tempB.next;
        }

        tempA = headA;
        tempB = headB;
        for (int i = 0; i < Math.Abs(lengthA - lengthB); ++i)
        {
            if (lengthA - lengthB > 0)
            {
                tempA = tempA.next;
            }
            else if (lengthA - lengthB < 0)
            {
                tempB = tempB.next;
            }
        }

        while (tempA != null || tempB != null)
        {
            if (tempA == tempB)
            {
                return tempA;
            }
            tempA = tempA.next;
            tempB = tempB.next;
        }
        return null;
    }
}