class Solution
{
    static void Main(string[] args)
    {
        // input = 121, is palindrom

        int input, r, sum, temp;

        Console.WriteLine("Put your number: ");
        input = int.Parse(Console.ReadLine());
        temp = input;
        sum = 0;

        while (input > 0)
        {
            r = input % 10; // r = 1
            sum = (sum * 10) + r; // sum = 1, sum = 12 (11+1), sum = 121 (120+1)
            input = input / 10; // input = 12, input = 1, input = 0
        }

        if(temp == sum)
        {
            Console.WriteLine("Number is palindrom");
        }
        else
        {
            Console.WriteLine("Number is not palindrom");
        }
    }

}
