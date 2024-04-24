
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; } = true;

    public Book(string title, string author) => (Title, Author) = (title, author);

    public void check_out() => Available = false;

    public void return_book() => Available = true;

    public string Stock() => Available ? "in stock" : "not in stock";

    public void read_details() => Console.WriteLine($"The book is named {Title} by the author {Author}. Status : {Stock()}");
}

class Library
{
    public string? Name { get; set; }
    public List<Book> Books { get; set; }  
    public List<Book> BooksAtCustomers {  get; set; } = new List<Book>(); 

    public Library(string name) => (Name, Books) = (name, new List<Book>());

    public void add_book(Book book) => Books.Add(book);
    public Book find_book(Book book) => Books.Contains(book) ? book : throw new Exception("Book not found");
    public void borrowing_book(Book book)
    {
        if (!Books.Contains(book)) throw new Exception("The book is not in the library in this moment");

        BooksAtCustomers.Add(book);
        Books.Remove(book);
    } 

}
