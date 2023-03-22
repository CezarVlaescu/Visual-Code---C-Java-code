class Solution
{
    static void Main(string[] args)
    {
        string s = "Hello World";
        var lWord = s.Length;
        var output = 0;
        var foundWord = false;

        for (int i = lWord-1; i >= 0; i--) 
        {
            if (s[i] == ' ')
            {
                foundWord = true;
                output++;
                continue;
            }
            else if (foundWord)
            {
                break;
            }
        }
        Console.WriteLine(output);

    }
}
