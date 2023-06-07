 string s = "abacaba"
// Substring the characters in partition, with each substring unique. ("ab", "a", "cab", "a")
// Return the number of partitions : 4

class Solution
{
    static public void Main(string[] args)
    {
        Console.WriteLine(PartitionString("Cezar"));
    }

    static public int PartitionString(string s)
    {
        int result = 1;
        if(string.IsNullOrEmpty(s)) { return 0; } // verify if string is null or 0 

        if(s.Length == 1) { return result; }

        HashSet<char> chars = new HashSet<char>();    // set for the chars 

        foreach(char c in s) 
        {
            if (chars.Contains(c)) // verify if c is in chars
            {
                result++; // if true, append the result
                chars = new HashSet<char>() { c }; // create another set with chars that override the chars
            }
            else
            {
                chars.Add(c); // if false, add in the set
            }
        }

        return result; // return the result
    }
}
