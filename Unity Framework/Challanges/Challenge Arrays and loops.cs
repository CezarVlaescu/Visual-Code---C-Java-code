class Solution
{
    static void Main(string[] args)
    {
        int arraySize;
        Console.WriteLine("Put the lenght of the array");
        arraySize = int.Parse(Console.ReadLine());

        string[] array = new string[arraySize];

        for (int i = 0; i < array.Length; i++) 
        {
            Console.WriteLine($"Put the value for index : {i}");
            array[i] = Console.ReadLine();
        }
        Console.WriteLine("All the names are : ");
        foreach(string str in array)
        {
            Console.WriteLine(str);
        }

     
    }
}
