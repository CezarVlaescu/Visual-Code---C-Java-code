using System;

namespace ref

{

class Program
{
    static void Main(string[] args) 
    { 
        // out keyword, tells the compiler that the obj will be initialized inside the funciton
        // ref keyword, tells the compiler that the obj is initialized before entering the function


        int substracted; 
        int multi; // at out we don't define the value 
        
        int divide = 2; // at ref we define the value before

        int added = Calculation(3, 3, out substracted, out multi, ref divide);

        Console.WriteLine($"The multi value is {multi}");
        Console.WriteLine($"The substracted value is {substracted}");
        Console.WriteLine($"The added value is {added}");
        Console.WriteLine($"The divided value is {divide}");

    }

    static int Calculation(int x, int y, out int substracted, out int multi, ref int divide)
    {
        divide = x / y;
        substracted = x - y;
        multi = x + y;
        return x * y;
    }
}
}
