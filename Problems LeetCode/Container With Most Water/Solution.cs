class Solution{
    static public void Main(string[] args)
    {
        int[] nums = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
        Console.WriteLine(maxArea(nums));
    }
    
    static public int maxArea(int [] nums)
    {
        int max = 0;
        int left = 0;
        int right = nums.Length - 1;
        
        while(left < right)
        {
             int width = right - left;
             max = Math.Max(max, Math.Min(nums[left], nums[right]) * width);
             if(nums[left] <= nums[right])
             {
                  left++;
             }
             else
             {
                  right--;
             }             
        }
        return max;
    }
