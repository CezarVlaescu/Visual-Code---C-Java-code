class Solution
{
    static public void Main(string[] args)
    {
        int[] nums = { 2, 1, 5, 0, 4, 6 };
        Console.WriteLine(InreasingTriplet(nums));
    }
    static public bool InreasingTriplet(int[] nums)
    {
        bool result = true;
        int length = nums.Length;
        int triplet = 3;

        for(int i=0; i<=length-triplet; i++)
        {
            if (nums[i] < nums[i+1] && nums[i+1] < nums[i+2])
            {
                result = true;
                break;
            }
            else
            {
                result = false;
            }
        }


        return result;
    }
}
