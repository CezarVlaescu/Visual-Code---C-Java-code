class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsPalindrom("A man, a plan, a canal: Panama"));
        Console.WriteLine(IsPalindrom("race a car"));
    }

    static public bool IsPalindrom(string s)
    { 
        if(IsEmpty(s)) return true;

        Stack<char> stack = new Stack<char>();
        StringBuilder sb = new StringBuilder();

        string replaced = ReplacedChars(s);

        foreach(char c in replaced)
        {
            stack.Push(c);
        }

        foreach(char c in stack)
        {
            sb.Append(c);
        }

        string builderString = sb.ToString();

        return (EqualsStrings(replaced, builderString));

    }

    static bool IsEmpty (string s)
    {
        return s == null || s.Length == 0;
    }

    static public string ReplacedChars(string s)
    {
        return s.Replace(" ", "").Replace(":", "").Replace("_", "").Replace(",", "").ToLower();
    }

    static bool EqualsStrings(string s1, string s2)
    {
        return s1 == s2;
    }

}
