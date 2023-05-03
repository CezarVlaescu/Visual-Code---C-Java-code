using System.Text;

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(Convert("Cezarescuestea", 4));
    }

    public static string Convert(string s, int numRows)
    {
        if(numRows == 1)
        {
            return s;                   
        }
        var result = new StringBuilder();
        var perIter = numRows * 2 - 2;

        for(int row = 0; row < numRows; row++) 
        {
            int i = 0;
            while((i+row) < s.Length)
            {
                result.Append(s[i+row]);
                if (row != 0 && row != numRows - 1)
                {
                    if((i+perIter-row)< s.Length)
                    {
                        result.Append(s[i+perIter-row]);    
                    }
                }
                i += perIter;
            }
            
        }
        return result.ToString();


        
    }
}
