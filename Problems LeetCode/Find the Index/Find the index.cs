class Solution
{
    static void Main(string[] args)
    {
        // string haystack = "sadbutsad"; s-a-d-b-u-t-s-a-d
        // string needle = "sad"; s-a-d
        // int index = 0;

        // if the needle in haystack return the value of index where the needle start, in our case it starts at 0, so return 0
        // if the needle aren't in kaystack, even if the word is in needle but have some diff like haystack = leetcode, needle = leeto (o) return -1

        int solution = StrStr("GeekforGeeks", "Geek");
        Console.WriteLine(solution);
    }


     static int StrStr(string haystack, string needle)
     {

         for (int i = 0; i < haystack.Length - needle.Length + 1; i++)
         { 
            if (haystack.Substring(i, needle.Length) == needle)
            {
               return i;
            }
         }
         return -1;
     }
}
