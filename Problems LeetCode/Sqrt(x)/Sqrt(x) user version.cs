class Solution
{
    static void Main(string[] args)
    {
        int x;
        Console.WriteLine("Sqrt of : ");
        x = int.Parse(Console.ReadLine());
        
        double y = (double)x;
        y = Math.Sqrt(y);
        int z = (int)y;
        
        Console.WriteLine($"The root of {x} is {z}");
        
    }
}
