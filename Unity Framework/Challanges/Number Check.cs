class Solution
{
    static void Main(string[] args)
    {
        float result = Add(2, 7);
        bool isEven = Check(result);

        if (isEven)
        {
            Console.WriteLine($"The number {result} is even");
        }
        else
        {
            Console.WriteLine($"The number {result} is odd");
        }
        

    }

    static float Add(float a, float b)
    {
        return a + b;
    }

    static bool Check(float c)
    {
        if (c % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
