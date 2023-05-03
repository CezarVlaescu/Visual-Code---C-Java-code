class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(LongestPalindrome("Cezazr"));
        Console.Read();
    }
    
    public static string LongestPalindrome(string s) 
    {
        var length = 1;
        var start = 0;

        for(var left =  0; left < s.Length; left++)
        {
            for (var right = s.Length - 1; right > left && right-left >= length; right--)
            {
                if(IsPalindromicSubstrating(left, right))
                {
                    start = left;
                    length = right - left + 1;  
                }
            }
        }
        return s.Substring(start, length);

        bool IsPalindromicSubstrating(int left, int right)
        {
            while (left < right)
            {
                if (s[left++] != s[right--])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
