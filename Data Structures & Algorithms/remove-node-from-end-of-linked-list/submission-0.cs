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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int count = 0;
        ListNode cur = head;
        while (cur != null) {
            count++;
            cur = cur.next;
        }

        int removeIndex = count - n;
        if (removeIndex == 0) {
            return head.next;
        }

        cur = head;
        for (int i = 0; i < count - 1; i++) {
            if (removeIndex == i + 1) {
                cur.next = cur.next.next;
                break;
            }
            cur = cur.next;
        }
        return head;
    }
}