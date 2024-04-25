using System.Security.Cryptography;
using System.Text;

class Solution
{
    static void Main()
    {
        Console.WriteLine(LongestIdealString("abcd", 3));
    }

    static readonly Dictionary<char, int> alphabet = new Dictionary<char, int>
    {
        {'a', 0},
        {'b', 1},
        {'c', 2},
        {'d', 3},
        {'e', 4},
        {'f', 5},
        {'g', 6}
    };

    static public int LongestIdealString(string s, int k)
    {
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i <= s.Length - 1; i++)
        {
            if (i == s.Length - 1) sb.Append(s[i]);
            else
            {
                if (Verify(s[i], s[i + 1], k)) sb.Append(s[i]);
                else if (!Verify(s[i], s[i + 1], k) && Verify(s[i - 1], s[i], k)) sb.Append(s[i]);
            }         
        }
        
        return sb.ToString().Length;
    }

    static public bool Verify(char c1, char c2, int k)
    {
        if (alphabet[c1] > alphabet[c2])
        {
            if (alphabet[c1] - alphabet[c2] <= k) return true;
            else return false;
        }
        else if (alphabet[c1] < alphabet[c2])
        {
            if (alphabet[c2] - alphabet[c1] <= k) return true;
            else return false;
        }
        else return false;
    }
}
