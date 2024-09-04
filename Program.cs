public class Program
{
    public static void PrintBooks(List<Book> bks){
        foreach(Book book in bks)
            Console.WriteLine(book);
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        Library lib = new Library();
        lib.addBook(new Book("B01", "Lap trinh HDT",
        "Nguyen Van At", new DateTime(2023, 12, 20),
        "NXB DHQG HN", 240, 210000, 23));
        lib.addBook(new Book("B01", "Ly thuyet do thi",
        "Nguyen Van Mau", new DateTime(2022, 10, 12),
        "NXB DHBK HN", 250, 230000, 25));
        PrintBooks(lib.Books);

        Console.ReadLine();
    }
}