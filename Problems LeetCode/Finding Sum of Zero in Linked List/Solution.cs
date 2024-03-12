public class ListNode
{
    public int value;
    public ListNode next;

    public ListNode(int value = 0, ListNode next = null) 
    {
        this.value = value;
        this.next = next;
    }
}

public class Solution
{
    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(-3);
        head.next.next.next = new ListNode(3);
        head.next.next.next.next = new ListNode(1);

        GetSums(head);  
    }

    static void GetSums(ListNode head)
    {
        int count = 1;

        if (count == GetCountOflist(GetValuesOfLinkedList(head))) return;

        SlidingWindow(GetValuesOfLinkedList(head), count + 1);
    }

    static int GetCountOflist(List<int> list) => list.Count;

    static List<int> GetValuesOfLinkedList(ListNode head)
    {
        List<int> values = new List<int>();

        while(head != null)
        {
            values.Add(head.value);
            head = head.next;
        }

        return values;
    }

    static List<List<int>> SlidingWindow(List<int> values, int size)
    {
        List<List<int>> list = new List<List<int>>();
        List<int> ints = new List<int>();
        int sum = 0;

        for(int i = 0; i < size; i++)
        {
            sum += values[i];
            ints.Add(values[i]);

            if (sum == 0) list.Add(ints);
        }

        for(int i = size; i < values.Count - 1; i++)
        {
            ints.RemoveAt(0);
            sum -= values[i - size];
            sum += values[i];
            ints.Add(values[i]);

            if(sum == 0) list.Add(ints);
        }

        return list;
    }
}
