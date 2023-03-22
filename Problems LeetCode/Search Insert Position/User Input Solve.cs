class Solution
{
    static void Main(string[] args)
    { 
        int[] nums = { 1, 3, 5, 7, 9 };  
        
        int last_num = nums[nums.Length - 1];
        
        int target;
        Console.WriteLine("Fix your target");
        target = int.Parse(Console.ReadLine());



        if (last_num < target)
        {
            Console.WriteLine($"Your target is out of array range, and should be on position : {nums.Length+1}");
        }
        Console.WriteLine();

        for (int i  = 0; i < nums.Length; i++)
        {
            if (nums[i] == target)
            {
                Console.WriteLine($"Your target is in array at position : {i}");
            }
            else if (nums[i] < target && target < nums[i + 1])
            {
                Console.WriteLine($"Your target is not in array but at position : {i+1}");
            }
        }
        
    }
}
