public class Solution 
{
    public int RemoveElement(int[] nums, int val) 
    {
        int res = 0;

        for (int i = 0; i < nums.Length; i++)
            if (nums[i] != val)
               nums[res++] = nums[i];
        return res;
    }
}
