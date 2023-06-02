using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(GcdofStrings("ABABAB", "ABAB"));
        Console.WriteLine(GcdofStrings("ABCABC", "ABC"));
    }

    public static string GcdofStrings(string str1, string str2)
    {
        int length1 = str1.Length; 
        int length2 = str2.Length;
        if((str1 + str2).Equals(str2 + str1)) 
        {
            int index = gcd(length1, length2);
            return str1.Substring(0, index);
        }
        else
        {
            return "";
        }
    } 

    public static int gcd(int n1, int n2)
    {
        if(n2 == 0)
        {
            return n1;
        }
        else
        {
            return gcd(n2, n1%n2);
        }
    }

}
