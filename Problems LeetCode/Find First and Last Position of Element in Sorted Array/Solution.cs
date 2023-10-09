class Solution
{
    static void Main(string[] args)
    {
        int[] nums = { 5,7,7,8,8,10 };

        Console.WriteLine(SearchRange(nums, 8));
    }

    public static int[] SearchRange(int[] nums, int target)
    {
        if(CheckTarget(nums, target) == true || IsNull(nums)) 
        {
            return new int[] { -1, -1 };
        }

        return nums.Select((num, index) => num == target ? index : -1).Where(index => index != -1).ToArray();

    }

    public static bool CheckTarget(int[] nums,int target) 
    {
        return !nums.Contains(target);
    }

    public static bool IsNull(int[] nums)
    {
        return nums.Length == 0;
    }

}
