public class Library
{
    private List<Book> books = new List<Book>();

    public Library(List<Book> books){
        this.Books = books;
    }
    public void addBook(Book book){
        books.Add(book);
    }
    public List<Book> find(string keyword){
        List<Book> result = new List<Book>();
        foreach(Book b in books)
            if(b.find(keyword))
                result.Add(b);
        return result;
    }

    public List<Book> Books { get => books; set => books = value; }
}