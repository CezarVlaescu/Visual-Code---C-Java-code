class Solution
{
    static void Main(string[] args)
    {
        int[] array = { 0, 0, 1, 1, 1, 1, 2, 2, 3 };
        Console.WriteLine(RemoveDuplicates(array)); 
    }

    public static int RemoveDuplicates(int[] nums)
    {
        int prev = nums[0];
        int start = 1;
        int current = 1;

        for(int i = 1; i < nums.Length; i++) 
        {
            if (nums[i] == prev) 
            {
                current++; 
            }
            else
            {
                current = 1; 
            }
            if(current <= 2) 
            {
                nums[start++] = nums[i]; 
            }
            prev = nums[i]; 
        }
        return start;      
    }
}

