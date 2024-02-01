class Solution
{
    static void Main()
    {
        int[] nums = { 1, 3, 4, 8, 7, 9, 3, 5, 1 }; // 1 1 3 3 4 5 7 8 9 
        Console.WriteLine(DivideArray(nums, 2));

    }

    static int[][] DivideArray(int[] nums, int k)
    {
        List<int[]> list = new();
        int[] result = new int[3];
        int count = 0;
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (count < 3 && (count == 0 || IsCompatibleWithResult(result, count, nums[i], k)))
            {
                result[count] = nums[i];
                count++;

                // If result array is filled, add it to the list and reset for the next subarray
                if (count == 3)
                {
                    list.Add((int[])result.Clone());
                    result = new int[3];
                    count = 0;
                }
            }
            else
            {
                // If current number does not fit, start a new subarray
                if (count > 0)
                {
                    list.Add((int[])result.Clone());  // Add the current partial result to the list
                }
                result = new int[3] { nums[i], 0, 0 }; // Start a new result with the current number
                count = 1;
            }
        }

        // Handle the last partially filled result array if it's valid
        if (count > 0 && count <= 3)
        {
            list.Add((int[])result.Clone());
        }

        return list.Count > 0 ? list.ToArray() : Array.Empty<int[]>();
    }

    static bool IsCompatibleWithResult(int[] result, int count, int newElement, int k)
    {
        for (int i = 0; i < count; i++)
        {
            if (Math.Abs(result[i] - newElement) > k)
            {
                return false;
            }
        }
        return true;
    }


}
