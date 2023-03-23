using System.Diagnostics.CodeAnalysis;

class Solution
{
    static void Main(string[] args)
    {
        int[] digits = { 1, 2, 3, 4 };

        string str = string.Join("", digits);
        int number = int.Parse(str);

        //Console.WriteLine(number);

        int addingOne = number + 1;
        //Console.WriteLine(addingOne);

        string numberParsed = addingOne.ToString();

        char[] arr = new char[] {};
        arr = arr.Concat(numberParsed).ToArray();

        int[] Converted = Array.ConvertAll(arr, c => (int)Char.GetNumericValue(c));

        foreach(int c  in Converted)
        {
            Console.WriteLine(c);
        }
       
    }
}
