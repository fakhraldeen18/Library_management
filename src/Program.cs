using sda_onsite_2_csharp_library_management.src;

internal class Program
{
    private static void Main()
    {
        var book2 = new Book("1984", new DateTime(2023, 2, 1));
        var book3 = new Book("1988", new DateTime(2023, 2, 1));

        var user8 = new User("Hannah", new DateTime(2024, 8, 1));
        var user10 = new User("Julia");
        
        var library = new Library("Jariry");
        library.AddUser(user8);
        library.AddUser(user10);
        var getUsers= library.GetUsers();
        getUsers.ForEach(item => Console.WriteLine(item.GetName()));
    }
}