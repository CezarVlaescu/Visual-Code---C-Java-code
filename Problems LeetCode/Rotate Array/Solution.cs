class Solution
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
        RotateArray(arr, 3);
        Rotate(arr, 4);

    }

    public static void RotateArray(int[] array, int k) // First Solution 
    {

        LinkedList<int> list = new LinkedList<int>(array);

        for(int i = 1; i <= k; i++)
        {
            list.RemoveLast();
            int last = array[array.Length - i];
            list.AddFirst(last);
        }

        array = list.ToArray();

        foreach(int j in array)
        {
            Console.WriteLine(j);
        }   
    }

    public static void Rotate(int[] nums, int k) // Second Solution
    {
        LinkedList<int> list = new LinkedList<int>(nums);

        for (int i = 0; i < k; i++)
        {
            list.AddFirst(list.Last.Value);
            list.RemoveLast();
        }

        var head = list.First;

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = head.Value;
            head = head.Next;
        }

        nums = list.ToArray();  

        foreach(int j in nums)
        {
            Console.WriteLine(j);
        }
    }

}
