using System.ComponentModel;

class Solution
{
    static void Main(string[] args)
    {
        // We need 2 lists of integers, with a lenght of n for l1 and m for l2

        Console.WriteLine("The lenght of first array : ");

        int n = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine($"Lenght of first array : {n}\n");


        int[] l1 = new int[n];

        // ---------------------------------------------------------------------------------------------------

        Console.WriteLine("The lenght of second array : ");

        int m = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine($"Lenght of second array : {m}");

        int[] l2 = new int[m];

        // ----------------------------------------------------------------------------------------------------

        // We need to add numbers in lists
        
        for(int i = 0; i < n; i++)
        {
            int add = int.Parse(Console.ReadLine());
            l1[i] = add;
            Console.WriteLine($"Number added : {add}");
        }
        Console.WriteLine($"Your first list : { string.Join(",", l1)}\n");

        for (int i = 0; i < m; i++)
        {
            int add1 = int.Parse(Console.ReadLine());
            l2[i] = add1;
            Console.WriteLine($"Number added : {add1}");
        }
        Console.WriteLine($"Your second list : {string.Join(",", l1)}\n");

        // We need to unite the numbers in one integer and sum each other 
        
        var number1 = int.Parse(string.Join("", l1));
        var number2 = int.Parse(string.Join("", l2));
        var result = number1 + number2;

        Console.WriteLine($"The result of suming united elements of arrays is {result}");

        // We need to adding the result of the sum in a list of integers

        List<int> list = new List<int>();
        while (result > 0)
        {
            list.Add(result % 10);
            result /= 10;   
        }
        foreach(int i in list)
        {
            Console.WriteLine(i);
        }
    }

}
