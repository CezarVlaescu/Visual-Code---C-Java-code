class Solution
{
    static void Main(string[] args)
    {
        int[] head = { 1, 1, 2 };
        int[] val = new int[head.Length-1];
        
        for(int i = 0; i < val.Length - 1; i++)
        {
            if (head[head.Length-1] != head[0])
            {
                val[val.Length-1] = head[head.Length-1];
            }
            if (head[i] == head[i + 1])
            {
                val[i] = head[i];
            }
        }
        foreach(int j in val)
        {
            Console.WriteLine(j);
        }
            
    }
}
