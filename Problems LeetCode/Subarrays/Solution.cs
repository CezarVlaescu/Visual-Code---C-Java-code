public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        int l = nums.Length;
        if(l == 1)
        {
            return nums[0] == goal ? 1 : 0;
        }
        int[] arrSum = new int[l + 1];
        int sum = 0;
        int count = 0;
        for (int i = 0; i < l; i++) {
            sum += nums[i];

            if (sum == goal) 
                count++;

            if (sum >= goal) 
                count += arrSum[sum - goal];

            arrSum[sum]++;
        }
        return count;
    }
}
