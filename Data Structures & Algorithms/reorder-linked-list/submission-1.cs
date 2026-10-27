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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null) return;

        // 1. Push all nodes onto the stack
        Stack<ListNode> stack = new Stack<ListNode>();
        ListNode curr = head;
        while (curr != null) {
            stack.Push(curr);
            curr = curr.next;
        }

        int count = stack.Count;
        curr = head;

        // 2. Interleave front nodes with nodes popped from stack
        for (int i = 0; i < count / 2; i++) {
            ListNode tailNode = stack.Pop();
            ListNode nextFront = curr.next;

            curr.next = tailNode;
            tailNode.next = nextFront;

            curr = nextFront;
        }

        // 3. Terminate the list cleanly at the middle node to prevent cycles
        curr.next = null;
    }
}
