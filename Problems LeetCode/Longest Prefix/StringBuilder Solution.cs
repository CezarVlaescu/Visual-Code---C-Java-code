using System.Text;

class Solution
{
    static void Main(string[] args)
    {
        int first, second, third;
        first = 0;
        second = 1;
        third = 2;
        string[] strings = new string[] {"flower", "flow", "flight"};
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < strings.Length; i++)
        {
            if (strings[i][first] == strings[i + 1][first] && strings[i + 1][first] == strings[i + 2][first])
            {
                sb.Append(strings[i][first]);

                if (strings[i][second] == strings[i + 1][second] && strings[i + 1][second] == strings[i + 2][second])
                {
                    sb.Append(strings[i][second]);

                    if (strings[i][third] == strings[i + 1][third] && strings[i + 1][third] == strings[i + 2][third])
                    {
                        sb.Append(strings[i][third]);

                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }

      
            // flower, flow, flight
            // strings[0] = flower, strings[1] = flow, strings[2] = flight ( for loop ) 
        
    }
}
 
