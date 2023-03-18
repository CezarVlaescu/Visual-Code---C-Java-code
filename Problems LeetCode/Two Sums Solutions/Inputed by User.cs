// Array - int , target - int

using System.Globalization;
using System.Runtime.ExceptionServices;

class Solution
{
    static void Main(string[] args)
    {
        int target;
        Console.WriteLine("Put your target: ");
        target = int.Parse(Console.ReadLine());
        Console.Write("\n");


        Console.WriteLine("Put the lenght of the array");
        int[] nums = new int[int.Parse(Console.ReadLine())]; 

        for (int i = 0; i < nums.Length; i++)
        {
            int value;
            Console.WriteLine("Put your values in array");            
            value = int.Parse(Console.ReadLine());
            nums[i] = value;
        }
        foreach(int j in nums)
        {
            Console.Write($"{j}");
            if (j < nums.Length)
            {
                Console.Write(",");
            }
        }
        for(int k = 0; k < nums.Length; k++)
        {
            if (nums[k] + nums[k+1] == target) 
            {
                int[] outputs = new int[] {k, k+1};
                foreach(int q in outputs)
                {
                    Console.WriteLine(q);
                }
            }
            else
            {
                Console.WriteLine("There is no values to find the target");
            }
        }
        
    }

    
}
