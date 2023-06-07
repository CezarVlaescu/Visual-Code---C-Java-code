public class Solution
{
    public static void Main(string[] args)
    {
        int[] nums = { 1, 2, 3, 4 };   
        Console.WriteLine(ProductExceptSelf(nums));
    }
    public static int[] ProductExceptSelf(int[] nums)
    {
        int[] product = new int[nums.Length];
        int num = 1, i;

        for (i = 0; i < nums.Length; i++)
        {
            product[i] = num;
            num *= nums[i]; 
        }
        num = 1;

        for (i = nums.Length - 1; i >= 0; i--)
        {
            product[i] *= num;
            num *= nums[i];
        }

        foreach(int j in product)
        {
            Console.WriteLine(j);   
        }
        return product;
    }
}
