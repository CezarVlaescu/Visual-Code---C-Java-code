using System.Net.Mail;

class Solution
{
    static void Main(string[] args)
    {
        Console.WriteLine(RemoveStars("leet***code**"));
    }

    /*public static string RemoveStars(string s)
    {
        char star = '*';
        Stack<char> stack = new Stack<char>();
        int length = s.Length-1;

        while (length >= 0) 
        {
            if (s[length] != star)
            {
                stack.Push(s[length]);
            }
            length--;
        }


        string result = string.Join("", stack);
        return result;
        
        
    }
    */

     public static string RemoveStars(string s)
     {
         var stack = new Stack<char>();
         for (int i = 0; i < s.Length; i++)
         {
            if (s[i] == '*')
                stack.Pop(); // Pop e, Pop e, Pop t, Pop d, Pop e - when finds a "*" pop the char at top of the stack
            else
                stack.Push(s[i]); // Push l, Push e, Push e, Push t, Push c, Push o, Push d, Push e -> edocteel -> after pops --oc---l ( ocl )
         }
         return string.Concat(stack.Reverse()); // lco 
     }
    

}
