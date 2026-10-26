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
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null)
            return head;

        ListNode oldHead = head;

        ListNode next = head.next;

        while (next != null) {
            // Console.WriteLine(head.val);
            ListNode temp = next.next;
            next.next = head;
            head = next;
            next = temp;
        }
        oldHead.next = null;
        return head;
    }
}
