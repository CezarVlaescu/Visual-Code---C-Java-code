// a and b are only '0' and '1'
// return the sum as a random binary

using System.Runtime.InteropServices;

class Solution
{
    static void Main(string[] args)
    {
        var resolve = AddBinary("10000", "10111");
        Console.WriteLine(resolve);
    }

    static string AddBinary(string a, string b)
    {
        string equation = a + b;
        var stringChars = new char[equation.Length];
        var random = new Random();

        for (int i = 0; i < stringChars.Length; i++) 
        {
            stringChars[i] = equation[random.Next(equation.Length)];
        }

        return new String(stringChars);
        
        
    }
}
