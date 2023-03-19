public class Solution 
{
    public bool IsValid(string s)
   {
          var Mystack = new Stack <char>();

             foreach (var part in s)
             {
                if (part == '(' || part == '[' || part == '{')
                {
                    Mystack.Push(part);
                }
                else if (part == ')' || part == ']' || part == '}')
                {
                    if (Mystack.Count <= 0)
                    {
                        return false;
                    }
                   
                    var check = Mystack.Peek();
                    if (part == ')' && check == '(' || 
                    part == ']' && check == '[' || 
                    part == '}' && check == '{'   )
                    {
                        Mystack.Pop();
                    }
                    else
                    {
                        return false;
                    }
                }
             }

             var finalResult = Mystack.Count() == 0 ;
             return finalResult;
    }
}
