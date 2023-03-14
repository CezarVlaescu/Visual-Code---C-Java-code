using System.Security.Cryptography.X509Certificates;

class Solution
{
    static int x, y;
    static void Main(string[] args)
    {
        Add();
        
        Substract();

        Divide();

        Multiply();
    }

    static void Add()
    {
        Console.WriteLine("Function : Add");

        Console.WriteLine("Enter your first number");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second number");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine($"{x} + {y} is {x+y}\n");
    }

    static void Substract()
    {
        Console.WriteLine("Function : Substract");

        Console.WriteLine("Enter your first number");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second number");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine($"{x} - {y} is {x - y}\n");
    }

    static void Divide()
    {
        Console.WriteLine("Function : Divide");

        Console.WriteLine("Enter your first number");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second number");
        y = int.Parse(Console.ReadLine());

        decimal z = x / y;

        Console.WriteLine($"{x} / {y} is {z}\n");
    }

    static void Multiply()
    {
        Console.WriteLine("Function : Divide");

        Console.WriteLine("Enter your first number");
        x = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second number");
        y = int.Parse(Console.ReadLine());

        Console.WriteLine($"{x} * {y} is {x * y}\n");
    }
}
