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
        Stack<ListNode> stack = new Stack<ListNode>();
        ListNode curr = head;
        while(curr!=null){
            stack.Push(curr);
            curr = curr.next;
        }

        int half = stack.Count/2;

        ListNode tmp = head;
        //ListNode next = ListNode(0, head);
        ListNode nextO = new ListNode();

        for(int i=0; i<half; i++){
            nextO = head.next;
            ListNode nextR = stack.Pop();
            head.next = nextR;
            nextR.next = nextO;
            head = nextO;
        }
        nextO.next = null;
        head = tmp;
    }
}
