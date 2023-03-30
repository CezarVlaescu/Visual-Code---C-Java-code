public class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        var list = new List<string>(n);

        for (int i = 1; i <= n; i++)
        {
            string item = (i % 3 == 0, i % 5 == 0) switch
            {
                (true, true) => "FizzBuzz",
                (true, false) => "Fizz",
                (false, true) => "Buzz",
                (false, false) => i.ToString()
            };

            list.Add(item);
        }

        return list;
    }
}
