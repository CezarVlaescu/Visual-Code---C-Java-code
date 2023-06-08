class Solution
{
    static public void Main(string[] args)
    {
        char[] chars = { 'a', 'a', 'b', 'b', 'c', 'c' };
        Console.WriteLine(Compress(chars)); 
    }
    static public int Compress(char[] chars)
    {
        int result = 0;
        char first = chars[0];
        int count = 1;
        int length = chars.Length;

        if(length == 0) { return 0; }
        
        for(int i = 1; i < length; i++) 
        {
            if(i< length && chars[i-1] == chars[i])
            {
                count++;
            }
            else
            {
                chars[result] = first;
                result += 1;

                string s = count.ToString();
                if(count > 1)
                {
                    for(int j = 0; j < s.Length; j++)
                    {
                        chars[result+j] = s[j];
                    }
                    result += s.Length;
                }
                if(i < length)
                {
                    first = chars[i];
                    count = 1;
                }
            }
        }
           
        return result;
    }
}
