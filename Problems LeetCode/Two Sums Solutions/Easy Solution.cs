// Array = [] some numbers and sum based by a target ( for exemple target = 9, sum the number who equals to 9 )

class Solution
{
    static void Main(string[] args)
    {
        // Target of the method 
        
        Array(9);
    }
    
    
    // Static method 
    
    static int Array(int target)
    {
        int [] array = { 2, 7, 10, 15};
        for(int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] + array[i+1] == target)
            {
                Console.WriteLine($"The numbers are {array[i]} and {array[i+1]}");
            }
        }
        return 0;
       

    }
}
