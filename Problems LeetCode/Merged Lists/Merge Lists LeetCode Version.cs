public class Solution 
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) 
    {
        if(list1 == null)
        {
            return list2;
        }
        if(list2 == null)
        {
            return list1;
        }
        if(list1.val >= list2.val)
        {
            ListNode tempNode = new ListNode(list1.val, list1.next);
            list1.val = list2.val;
            list1.next = tempNode;

            return MergeTwoLists(list1, list2.next);
        }
        else
        {
            list1.next = MergeTwoLists(list1.next, list2);
        }
        return list1;  
    }
}
