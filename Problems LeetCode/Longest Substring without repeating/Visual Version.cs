class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(Longest("abcabcbb"));
        Console.Read();
    }

    public static int Longest(string s)
    {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        int max = 0;

        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (!dict.ContainsKey(c))
            {
                dict.Add(c, i);
                max = Math.Max(dict.Count, max);
            }
            else
            {
                i = dict[c];
                dict.Clear();
            }
        }
        return max;
    }
}
