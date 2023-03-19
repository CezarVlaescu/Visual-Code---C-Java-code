using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];

        var prefixString = "";
        
        if (strs == null || strs.Length == 0)
            return prefixString;
            
        for (int i = 0; i < strs[0].Length; i++)
        {
            foreach (string str in strs)

                if (i > str.Length - 1)
                    return prefixString;

                if (strs[0][i] != str[i])
                    return prefixString;
            }
            prefixString += strs[0][i];
        }

        return prefixString;
    }
}
