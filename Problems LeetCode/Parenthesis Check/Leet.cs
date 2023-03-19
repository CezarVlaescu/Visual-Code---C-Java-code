public class Solution 
{
    public bool IsValid(string s)
   {
          var Mystack = new Stack <char>();

             foreach (var its in s)
             {
                if (its == '(' || its == '[' || its == '{')
                {
                    Mystack.Push(its);
                }
                else if (its == ')' || its == ']' || its == '}')
                {
                    if (Mystack.Count <= 0)
                    {
                        return false;
                    }
                   var check = Mystack.Peek();
                   if (its == ')' && check == '(' || 
                    its == ']' && check == '[' || 
                    its == '}' && check == '{'   )
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
