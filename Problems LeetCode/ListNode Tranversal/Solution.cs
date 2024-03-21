public class Solution {
    public ListNode ReverseList(ListNode head) {
        Stack<ListNode> tranverse = new Stack<ListNode>();

        while(head != null){
            tranverse.Push(head);
            head = head.next;
        }
        
        ListNode dummy = new ListNode(-1);
        ListNode current = dummy;

        while(tranverse.Count > 0){
            current.next = tranverse.Pop();
            current = current.next;
        }

        current.next = null;

        return dummy.next; 
    }
}
