using System.Text;

class Soltution
{
    static void Main(string[] args)
    {
        Console.Write("Tell me what your password length is : ");
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine($"This is your password : {GetPassword(length)}"); 
    }

    static string GetPassword(int length)
    {
        Random r = new Random();
        List<dynamic> passowordList = new List<dynamic>();
        StringBuilder sb = new StringBuilder(); 
        char[] uppers = { 'A', 'E', 'X', 'Q' };
        char[] lowers = { 'b', 'n', 'o', 'p' };
        int[] ints = {1, 2, 3, 4, 5, 6, 7 ,8 ,9 };

        int count = length;

        if (length <= 0) throw new Exception("You didn't pass a positive length for password");

        while(count > 0)
        {
            passowordList.Add(uppers[r.Next(uppers.Length)]);
            passowordList.Add(ints[r.Next(ints.Length)]);
            passowordList.Add(lowers[r.Next(lowers.Length)]);
            count -= 3;           
        }

        foreach(dynamic ps in passowordList)
        {
            sb.Append(ps.ToString());   
        }

        return sb.ToString();

    }
}
