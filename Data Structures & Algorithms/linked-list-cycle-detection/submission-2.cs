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
    public bool HasCycle(ListNode head)
    {
        if (head == null || head.next == null) return false;
        ListNode slow = head;
        ListNode fast = head;

        while (slow != null && fast != null)
        {
            slow = slow.next;
            if (fast != null)
            {
                if(fast.next == null) return false;
                fast = fast.next.next;
            }
            if (slow == fast) return true;
        }

        return false;
    }
}
