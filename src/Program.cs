using sda_onsite_2_csharp_library_management.src;

internal class Program
{
    private static void Main()
    {

        var user8 = new User("Hannah", new DateTime(2024, 8, 1));
        var user10 = new User("Julia");
        var user11 = new User("Abbas");

        var book3 = new Book("To Kill a Mockingbird", new DateTime(2023, 3, 1));
        var book1 = new Book("The Great Gatsby", new DateTime(2023, 1, 1));
        var book4 = new Book("The Catcher in the Rye", new DateTime(2023, 4, 1));
        var book2 = new Book("1984", new DateTime(2023, 2, 1));

        var library = new Library("Jariry");
        library.AddUser(user8);
        library.AddUser(user10);

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        library.AddBook(book4);

        var getUsers = library.GetUsers();
        getUsers.ForEach(item => Console.WriteLine(item.GetName()));
        Console.WriteLine("========================");
        library.FindUsers(user11.GetName());
        library.FindBook(book2.GetTitle());
        Console.WriteLine("========================");
        var getBooks = library.GetBooks();
        getBooks.ForEach(book => Console.WriteLine(book.GetTitle()));
        Console.WriteLine("========================");
        Console.WriteLine(book2.GetId());
        library.DeleteBook(book2.GetId());
        Console.WriteLine("========================");
        getBooks.ForEach(book => Console.WriteLine(book.GetTitle()));
        Console.WriteLine("========================");
        var BookSorting = library.GetBooksByDate(SortType.DESC);
        BookSorting.ForEach(book => Console.WriteLine($"Date {book.GetDate()}") );

    }
}