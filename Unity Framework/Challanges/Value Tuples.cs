using System.Transactions;

namespace Tuples 
{
class Program
{
    static void Main(string[] args)
    {
        (string, int, string) values = Caracter();
        Console.WriteLine($"Your character name is {values.Item1}, age {values.Item2}, gender {values.Item3}");
    }
    static (string playerName, int age, string gender) Caracter()
    {
        Console.WriteLine("Enter your player name");
        string playerName = Console.ReadLine();

        Console.WriteLine("Enter your age");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your gender");
        string gender = Console.ReadLine();

        return (playerName, age, gender);   

    }

}
}
