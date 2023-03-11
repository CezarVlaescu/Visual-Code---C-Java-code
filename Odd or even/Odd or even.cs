class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine("Odd or Even Program!\n");

        Random random1 = new Random();
        int r1 = random1.Next(10);
        int r2 = random1.Next(10);
        Console.WriteLine($"The first number is {r1}");
        Console.WriteLine($"Second number is {r2}\n");

        if (r1 % 2 == 0)
        {
            Console.WriteLine($"Number {r1} is odd");
        }
        else if (r1 % 2 != 0)
        {
            Console.WriteLine($"Number {r1} is even");
        }
        if (r2 % 2 == 0) 
        {
            Console.WriteLine($"Number {r2} is odd");
        }
        else if (r2 % 2 != 0)
        {
            Console.WriteLine($"Number {r2} is even");
        }

        Console.ReadLine();

    }
}
