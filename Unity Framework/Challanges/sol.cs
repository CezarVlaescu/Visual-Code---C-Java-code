public class Solution {
    public int FindMaxK(int[] nums) {
        if(nums.All(v => v <  0)) return -1;
        Array.Sort(nums);
        int end = nums.Length - 1;

        while(0 <= end){
            if(nums[end] < 0) break;
            
            if(nums.Contains(0 - nums[end])) return nums[end];
            else end--;
        }
        return -1;
    }
}
