// int[] nums = new array[]
// int k;
// from nums, we pick 2 numbers and the sum should equal to k 
// this nums will be removed from the array 
// return the maximum number of operation perform on the array 

// ex : nums = {1, 2, 3, 4}
//      k = 5 -> 1 + 4 => nums = { 2, 3 }
//            -> 2 + 3 -> nums = { } 
//      return 2


class Solution
{
    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4, 5 };
        Console.WriteLine(MaxOperations(nums, 5));
    }

    static int MaxOperations(int[] nums, int k)
    {
        Array.Sort(nums);
        int result = 0;
        int left = 0;
        int right = nums.Length - 1;
 
        while (left < right) 
        {
            int sum = nums[left] + nums[right];

            if(sum == k)
            {
                result++;
                left++;
                right--;
            }
            else if (sum < k)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return result;
    }
}
