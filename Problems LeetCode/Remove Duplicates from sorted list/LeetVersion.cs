public class Solution{
    public ListNode DeleteDuplicates(ListNode head)
    {
       if(head == null){
           return head;
       }
       if(head.next == null){
           return head;
       }
       
       ListNode prevNode = head;
       for(ListNode node = head.next; node != null; node = node.next)
       {
           if(node.val == prevNode.all)
           {
              prevNode.next = node.next;
           }
           else
           {
              prevNode = node;
           }
       }
       return head;
    }
}
