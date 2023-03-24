class Solution
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("n = ");
        n = int.Parse(Console.ReadLine());

        if (n <= 2)
        {
            Console.WriteLine(n);
        }

        int val1 = 1;
        int val2 = 2;
        int result = 0;

        for(int i = 2; i<n; i++)
        {
            result = val1 + val2;
            val1 = val2;
            val2 = result;
        }
        Console.WriteLine(val2);

    }
}
