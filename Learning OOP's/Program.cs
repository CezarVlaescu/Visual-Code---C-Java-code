using Oops;

class OOP
{
    static void Main(string[] args)
    {
        Books book = new Books("Crime", "Lev Tolstoi", 9);
        book.SetName("Wraith of War");
        Console.WriteLine(book.GetDescription());
        Console.WriteLine(book.maxPages());

    }
}
