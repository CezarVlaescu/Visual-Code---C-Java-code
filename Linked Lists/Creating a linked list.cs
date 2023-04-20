class Program
{
    /* [N] > [A] > [B] > [C] > null
       [0]   [5],  [9],  [10]
       [A],  [B],  [C],  [null] */

    class LinkedListNode // creating a linked list
    {
        public int data;
        public LinkedListNode next;

        public LinkedListNode(int x)
        {
            data = x;
            next = null;
        }
    }

    class LinkedList
    {
        LinkedListNode head;
        int count;

        public LinkedList()
        {
            head = null;
            count = 0; 
        }

        public void AddNodeToFront(int data)
        {
            LinkedListNode node = new LinkedListNode(data);
            node.next = head;
            head = node;
            count++;
        }

        public void PrintList()
        {
            LinkedListNode runner = head;
            while(runner != null)
            {
                Console.WriteLine(runner.data);
                runner = runner.next;
            }
        }
    }

    static void Main(string[] args)
    {
        LinkedList linkList = new LinkedList();
        linkList.AddNodeToFront(5);
        linkList.AddNodeToFront(6);
        linkList.AddNodeToFront(7);
        linkList.AddNodeToFront(8);
        linkList.AddNodeToFront(9);
        linkList.PrintList();
    }
}
